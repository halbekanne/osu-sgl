using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Nodes.Methods
{
    public interface IMethod
    {
        public abstract Value Invoke(List<Value> parameters);
        public abstract string GetName();
        public abstract int GetParameterNumer();
        public abstract string InputParametersAsString();
    }
}
