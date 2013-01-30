using System;
using System.Globalization;
using System.Text;

namespace SGL.Storyboard
{
    internal class Animation : Command
    {
        private readonly AnimationType animationType;
        private readonly int easing;
        private readonly double[] endParams;
        private readonly int endTime;
        private readonly double[] startParams;

        /// <summary>
        /// Cunstructor for normal storyboard commands
        /// </summary>
        /// <param name="easing"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="startParams"></param>
        /// <param name="endParams"></param>
        public Animation(AnimationType animationType, int easing, int startTime, int endTime, double[] startParams,
                         double[] endParams)
        {
            this.animationType = animationType;
            this.easing = easing;
            this.startTime = startTime;
            this.endTime = endTime;
            this.startParams = startParams;
            this.endParams = endParams;
        }

        public Animation(AnimationType animationType, int startTime, int endTime, double[] startParams,
                         double[] endParams)
            : this(animationType, 0, startTime, endTime, startParams, endParams)
        {
        }

        public Animation(AnimationType animationType, int startTime, double[] startParams)
            : this(animationType, 0, startTime, startTime, startParams, startParams)
        {
        }

        public Animation(AnimationType animationType, double[] startParams)
            : this(animationType, 0, 0, 0, startParams, startParams)
        {
        }

        public override void AddSoryboardCode(StringBuilder storyboardCode)
        {
            switch (animationType)
            {
                case AnimationType.Move:
                    storyboardCode.Append(" M," + easing + "," + startTime + "," + endTime + "," +
                                          ((int) startParams[0]).ToString(CultureInfo.InvariantCulture) + "," +
                                          ((int) startParams[1]).ToString(CultureInfo.InvariantCulture) + "," +
                                          ((int) endParams[0]).ToString(CultureInfo.InvariantCulture) + "," +
                                          ((int) endParams[1]).ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.MoveX:
                    storyboardCode.Append(" MX," + easing + "," + startTime + "," + endTime + "," +
                                          ((int) startParams[0]).ToString(CultureInfo.InvariantCulture) + "," +
                                          ((int) endParams[0]).ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.MoveY:
                    storyboardCode.Append(" MY," + easing + "," + startTime + "," + endTime + "," +
                                          ((int) startParams[0]).ToString(CultureInfo.InvariantCulture) + "," +
                                          ((int) endParams[0]).ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.Fade:
                    storyboardCode.Append(" F," + easing + "," + startTime + "," + endTime + "," +
                                          startParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[0].ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.Scale:
                    storyboardCode.Append(" S," + easing + "," + startTime + "," + endTime + "," +
                                          startParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[0].ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.ScaleVec:
                    storyboardCode.Append(" V," + easing + "," + startTime + "," + endTime + "," +
                                          startParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          startParams[1].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[1].ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.Rotate:
                    storyboardCode.Append(" R," + easing + "," + startTime + "," + endTime + "," +
                                          startParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[0].ToString(CultureInfo.InvariantCulture));
                    break;
                case AnimationType.Color:
                    storyboardCode.Append(" C," + easing + "," + startTime + "," + endTime + "," +
                                          startParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          startParams[1].ToString(CultureInfo.InvariantCulture) + "," +
                                          startParams[2].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[0].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[1].ToString(CultureInfo.InvariantCulture) + "," +
                                          endParams[2].ToString(CultureInfo.InvariantCulture));
                    break;
                default:
                    throw new Exception("Unimplemented animation type - Error should never occur");
            }
            storyboardCode.Append("\r\n");
        }


        public override String ToString()
        {
            return "SbAnimation (" + animationType + "): " + easing + "," + startTime + "," + endTime + "," +
                   startParams + "," + endParams;
        }
    }
}