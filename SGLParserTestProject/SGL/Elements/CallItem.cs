using System;

namespace SGL.Elements
{
    internal class CallItem
    {
        public CallItem(String call, int line)
        {
            this.Call = call;
            this.Line = line;
        }

        public String Call { get; set; }

        public int Line { get; set; }
    }
}