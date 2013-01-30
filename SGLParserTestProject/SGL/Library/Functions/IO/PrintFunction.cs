using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Library.Functions.IO
{
    internal class PrintFunction : Function
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