using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;
using System.Globalization;

namespace SGL.Library.Functions.IO
{
    class PrintFunction : Function
    {

        private void print(Value value)
        {
            GlobalMemory.Instance.debugAddLine(value.ToString());
        }

        public override Value Invoke(List<Value> param)
        {
            print(param[0]);
            return Value.VOID;
        }
    }
}
