using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class AtomNode : SGLNode
    {
        private SGLValue value;

        public AtomNode(Object v)
        {
            value = (v == null) ? SGLValue.NULL : new SGLValue(v);
        }

        public SGLValue Evaluate()
        {
            return value;
        }

        public String ToString()
        {
            return value.ToString();
        }



    }
}
