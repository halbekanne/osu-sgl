using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Storyboard
{
    abstract class Command : IComparable
    {
        public int startTime;

        public int CompareTo(Object o)
        {
            if (o is Command)
            {
                return this.startTime - ((Command)o).startTime;
            }
            else
            {
                // TODO: Exception
                throw new Exception("Storyboard commands can't be compared");
            }

        }

        public abstract void AddSoryboardCode(StringBuilder storyboardCode);
    }
}
