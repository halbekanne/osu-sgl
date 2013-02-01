using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld
{
    public class UnexpectedException : Exception
    {
        public String title;
        public String trueStackTrace;

        public UnexpectedException(String title, String trueStackTrace)
        {
            this.title = title;
            this.trueStackTrace = trueStackTrace;


        }
    }
}
