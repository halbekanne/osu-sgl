using System;
using System.Text;

namespace SGL.Storyboard
{
    public abstract class Command : IComparable
    {
        public int startTime;

        #region IComparable Members

        public int CompareTo(Object o)
        {
            if (o is Command)
            {
                return startTime - ((Command) o).startTime;
            }
            else
            {
                // TODO: Exception
                throw new Exception("Storyboard commands can't be compared");
            }
        }

        #endregion

        public abstract void AddSoryboardCode(StringBuilder storyboardCode);
    }
}