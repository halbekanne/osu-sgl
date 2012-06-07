using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Library.Functions.IO
{
    class PrintFunction : Function
    {

        private void print(object value)
        {
            GlobalMemory.Instance.debugAddLine(value.ToString());
        }

        public override Value Invoke(List<Value> param)
        {
            print(param[0].RawValue);
            return Value.VOID;
        }
    }
}
