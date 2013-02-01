using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld.Types
{
    public class ReturnValue
    {
        public Type type = typeof(ReturnValue);

        public Value value = null;

        public ReturnValue(Value value)
        {
            this.value = value;
        }
    }
}
