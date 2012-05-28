using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SGL.Elements;

namespace SGL.Methods
{
    class SinMethod : Method
    {

        private Value sin(double value)
        {
            return new Value(Math.Sin(value), ValType.Double);
        }

        public override Elements.Value InvokeMethod(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.Double)) return sin(param[0].DoubleValue);

            // TODO: Exception
            throw new Exception();
        }

    }
}
