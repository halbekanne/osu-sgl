using System;
using System.Collections.Generic;
using System.Text;
using SGL.Elements;

namespace SGL.Library.Functions.Calculation
{
    class RandFunction : Function
    {
        private Value rand(int minimum, int maximum)
        {
            if (minimum > maximum) throw new CompilerException(-1, 317, "rand(min, max)", "The value for 'min' must be less or equal to the value for 'max'.");
            Random random = GlobalMemory.Instance.Random;
            return new Value(random.Next(minimum,maximum+1), ValType.Integer);
        }

        public override Value Invoke(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.Integer, ValType.Integer)) return rand(param[0].IntValue, param[1].IntValue);

            // TODO: Name
            throw new CompilerException(-1, 302, "sin", Value.PrintTypeList(param));
        }
    }
}
