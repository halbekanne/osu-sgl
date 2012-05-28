using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld
{
    public class ComList<T> : List<T> where T : SbCommand
    {
        public ComList<T> GetOffsetList(int offset)
        {
            ComList<T> copy = this;
            foreach (SbCommand com in copy)
            {
                if (com is SbAnimation) {
                    SbAnimation animCom = (SbAnimation)com;
                    animCom.startTime += offset;
                    animCom.endTime += offset;
                }
            }
            return copy;
        }
    }
}
