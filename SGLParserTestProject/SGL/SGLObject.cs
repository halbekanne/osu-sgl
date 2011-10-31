using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLObject : IComparable
    {
        public enum Attribute
        {
            x, y, red, green, blue, opacity, scale, scaleX, scaleY, rotate
        }

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
        public ComList<SbCommand> commands = new ComList<SbCommand>();

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
                case SbAnimation.AnimationType.move: storyboardCode.Append(" M," + cmdAnim.easing + "," + cmdAnim.startTime + "," + cmdAnim.endTime + "," + ((int)cmdAnim.startParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmdAnim.startParams[1]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmdAnim.endParams[0]).ToString(System.Globalization.CultureInfo.InvariantCulture) + "," + ((int)cmdAnim.endParams[1]).ToString(System.Globalization.CultureInfo.InvariantCulture));
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


        // Special methods


        public float GetAttributeAtTime(Attribute attr, int time)
        {
            return GetAttributeAtTime(commands, attr, time);
        }

        /// <summary>
        /// This method will look up a specific attribute of the Object at a specific time
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public float GetAttributeAtTime(ComList<SbCommand> comList, Attribute attr, int time)
        {
            // first sort all commands - this shouldn't affect the output in a way it won't work anymore
            // using Quicksort
            commands.Sort();

            foreach (SbCommand command in comList)
            {

                switch (attr)
                {
                    case Attribute.x:
                        if (command is SbStandardLoop)
                        {
                            SbStandardLoop loop = (SbStandardLoop)command;
                            ComList<SbCommand> loopCommands = loop.GetAnimationList();
                            for (int count = 0; count < loop.count; count++)
                            {
                                if (loop.startTime + (loop.GetLongest() * (count + 1)) >= time)
                                {
                                    int offset = loop.startTime + (loop.GetLongest() * count);
                                    return GetAttributeAtTime(loopCommands.GetOffsetList(offset), attr, time);
                                }
                            }
                        }
                        if (command is SbAnimation)
                        {
                            SbAnimation comAnim = (SbAnimation)command;
                            if (comAnim.animationType == SbAnimation.AnimationType.move || comAnim.animationType == SbAnimation.AnimationType.moveX)
                            {
                                if (comAnim.endTime >= time)
                                {
                                    Console.WriteLine(comAnim.ToString());
                                    // should be the only event
                                    // calculate X position
                                    // first, zero-base everything
                                    int zeroEnd = comAnim.endTime - comAnim.startTime;
                                    int zeroTime = time - comAnim.startTime;

                                    Console.WriteLine("zeroEnd: " + zeroEnd);
                                    Console.WriteLine("zeroTime: " + zeroTime);

                                    // hand it over to the calc
                                    float part = CalcAnimationPosition(zeroEnd, zeroTime, comAnim.easing);



                                    // For move and moveX, parameter 0 is the x value
                                    int span = (int)(comAnim.endParams[0] - comAnim.startParams[0]);
                                    Console.WriteLine("span: " + span);
                                    Console.WriteLine("result: " + ((float)(comAnim.startParams[0] + (span * part))));
                                    return (float)(comAnim.startParams[0] + (span * part));
                                }
                            }
                        }
                        break;

                }


            }


            return 0;

        }


        /// <summary>
        /// Calculates the animation's "position", meaning the part where the animation "is" at a specific time.
        /// Think of it as how much (0.0-1.0) of the animation took already place till a specific time.
        /// Zero-Based
        /// Thank you peppy for your gist: https://gist.github.com/1235731
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="reqTime"></param>
        /// <param name="easing"></param>
        /// <returns></returns>
        private float CalcAnimationPosition(int duration, int reqTime, int easing)
        {
            // trivial cases
            if (reqTime == 0) return 0;
            if (reqTime == duration) return 1;

            // everything in between
            switch (easing)
            {
                case 0: 
                    // Easing 0
                    Console.WriteLine("0 part: " + (reqTime / (float)duration));
                    return reqTime / (float)duration;
                case 1:
                    // Easing 1
                    Console.WriteLine("1 part: " + (1 - (float)Math.Pow(reqTime / (float)duration, 2)));
                    return 1 - (float)Math.Pow(reqTime / (float)duration, 2);
                case 2:
                    // Easing 2
                    Console.WriteLine("2 part: " + ((float)Math.Pow(reqTime / (float)duration, 2)));
                    return (float)Math.Pow(reqTime / (float)duration, 2);
            }


            return 0;
        }



    }
}
