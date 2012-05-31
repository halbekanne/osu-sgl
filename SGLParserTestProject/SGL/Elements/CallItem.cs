using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Elements
{
    private class CallItem
    {
        private string call;
        private int line;

        public CallItem(String call, int line)
        {
            this.call = call;
            this.line = line;
        }
        public String Call
        {
            get { return call; }
            set { call = value; }
        }
        public int Line
        {
            get { return line; }
            set { line = value; }
        }
    }
}
