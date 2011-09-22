using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SbCommand : IComparable
    {
        public int easing;
        public int startTime;
        public int endTime;
        public double[] startParams;
        public double[] endParams;

        public SbCommand(int easing, int startTime, int endTime, double[] startParams, double[] endParams)
        {
            this.easing = easing;
            this.startTime = startTime;
            this.endTime = endTime;
            this.startParams = startParams;
            this.endParams = endParams;
        }


        public int CompareTo(Object o)
        {
            if (o is SbCommand)
            {
                return this.startTime - ((SbCommand)o).startTime;
            }
            else
            {
                throw new Exception("SbCommand can't be compared");
            }

        }

    }
}
