using System;
using System.Collections.Generic;
using SGL.Elements;

namespace SGL.Library.Functions.Calculation
{
    internal class SinFunction : Function
    {
        private Value sin(double value)
        {
            return new Value(Math.Sin(value), ValType.Double);
        }

        public override Value Invoke(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.Double)) return sin(param[0].DoubleValue);

            // TODO: Name
            throw new CompilerException(-1, 302, "sin", Value.PrintTypeList(param));
        }
    }
}