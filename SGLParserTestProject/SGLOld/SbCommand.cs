using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld
{
    public class SbCommand : IComparable
    {
        public int startTime;

        public int CompareTo(Object o)
        {
            if (o is SbAnimation)
            {
                return this.startTime - ((SbAnimation)o).startTime;
            }
            else
            {
                throw new Exception("SbCommand can't be compared");
            }

        }

    }

    public class SbLoop : SbCommand
    {
        protected ComList<SbCommand> animations = new ComList<SbCommand>();
        protected int longest = 0;

        public void AddAnimation(SbAnimation animation)
        {
            animations.Add(animation);
            if (animation.endTime > longest)
            {
                longest = animation.endTime;
            }
        }

        public ComList<SbCommand> GetAnimationList()
        {
            return animations;
        }

        public int GetLongest()
        {
            return longest;
        }
    }

    public class SbStandardLoop : SbLoop {

        public int count;

        /// <summary>
        /// Cunstructor for normal loops
        /// </summary>
        /// <param name="loopStartTime"></param>
        /// <param name="loopCount"></param>
        public SbStandardLoop(int loopStartTime, int loopCount)
        {
            this.startTime = loopStartTime;
            this.count = loopCount;
        }

    }


    public class SbTriggerLoop : SbLoop {

        public int endTime;
        public String trigger;
        

        /// <summary>
        /// Cunstructor for trigger loops
        /// </summary>
        /// <param name="loopStartTime"></param>
        /// <param name="loopEndTime"></param>
        /// <param name="trigger"></param>
        public SbTriggerLoop(int loopStartTime, int loopCount, String trigger)
        {
            this.startTime = loopStartTime;
            this.endTime = loopCount;
            this.trigger = trigger;
        }

    }


    public class SbAnimation : SbCommand {
        public enum AnimationType { move, moveX, moveY, scale, scaleVec, fade, rotate, color }

        public AnimationType animationType;
        public int easing;
        public int endTime;
        public double[] startParams;
        public double[] endParams;
        
        


        /// <summary>
        /// Cunstructor for normal storyboard commands
        /// </summary>
        /// <param name="easing"></param>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="startParams"></param>
        /// <param name="endParams"></param>
        public SbAnimation(AnimationType animationType, int easing, int startTime, int endTime, double[] startParams, double[] endParams)
        {
            this.animationType = animationType;
            this.easing = easing;
            this.startTime = startTime;
            this.endTime = endTime;
            this.startParams = startParams;
            this.endParams = endParams;
        }



        public String ToString()
        {
            return "SbAnimation (" + animationType + "): " + easing + "," + startTime + "," + endTime + "," + startParams.ToString() + "," + endParams.ToString(); 
        }
    }
}
