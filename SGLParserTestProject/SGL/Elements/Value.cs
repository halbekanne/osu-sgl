using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using SGL.Library.Classes;

namespace SGL.Elements
{

    public class Value : IComparable<Value>
    {
        // return null;
        public static readonly Value NULL = new Value();
        // no return
        public static readonly Value VOID = new Value();
        // break;
        public static readonly Value BREAK = new Value();
        // for error stacktracing
        public static readonly Value INVALID = new Value();

        private object value;

        private ValType type;

        public object Value
        {
            get
            {
                return value;
            }
        }

        public ValType Type
        {
            get
            {
                return type;
            }
        }

        // object with the value information
        public int IntValue {
            get
            {
                // TODO: Exception
                if (type == ValType.Integer || type == ValType.Double) return (int)value;
                else throw new Exception();
            }
        }

        public double DoubleValue
        {
            get
            {
                // TODO: Exception
                if (type == ValType.Double || type == ValType.Integer) return (double)value;
                else throw new Exception();
            }
        }

        public bool BoolValue
        {
            get
            {
                // TODO: Exception
                if (type == ValType.Boolean) return (bool)value;
                else throw new Exception();
            }
        }

        public string StringValue
        {
            get
            {
                // TODO: Exception
                if (type == ValType.String) return (string)value;
                else throw new Exception();
            }
        }

        public Class ObjectValue
        {
            get
            {
                // TODO: Exception
                if (type == ValType.Object) return (Class)value;
                else throw new Exception();
            }
        }

        public List<Value> ListValue
        {
            get
            {
                // TODO: Exception
                if (type == ValType.Object) return (List<Value>)value;
                else throw new Exception();
            }
        }

        public Value ReturnValue
        {
            get
            {
                // TODO: Exception
                if (type == ValType.Return) return (Value)value;
                else throw new Exception();
            }
        }

        private Value()
        {
            // private constructor: only used for NULL, VOID, BREAK, ...
        }


        public Value(object value, ValType type)
        {
            if (value == null)
            {
                throw new Exception("v == null");
            }

            this.value = value;
            this.type = type;
            /*
            if (type == ValType.String)
            {
                // escape sequences
                String newString = AsString();
                newString = newString.Replace("\\\\", "\\");
                newString = newString.Replace("\\\"", "\"");
                value = newString;
            }
            */
        }



        // Compare one value to another
        public int CompareTo(Value that)
        {
            try
            {
                // this comparison can fail, but it may be covered by the next comparisons
                if (this.Value is IComparable && that.Value is IComparable)
                {
                    // if both can be compared, use that to compare both
                    return ((IComparable)this.Value).CompareTo(that.Value);
                }
            }
            finally
            {
                    throw new Exception("illegal expression: can't compare `" +
                        this + "` to `" + that + "`");
            }
        }

        // Checks if one value is the same as another value
        public override Boolean Equals(Object o)
        {
            /*
            ValType thisType = this.GetType();
            
            ValType thatType = that.GetType();
            */
            Value that = (Value)o;

            if (this.TypeEquals(ValType.Double, true) || that.TypeEquals(ValType.Double, true))
            {
                // Float Comparison
                double diff = Math.Abs(this.DoubleValue - that.DoubleValue);
                return diff < 0.00000000001;
            }
            else if (this.TypeEquals(ValType.Integer, true) && that.TypeEquals(ValType.Integer, true))
            {
                // Integer Comparison
                return this.IntValue == that.IntValue;
            }
            else if (this.Type == ValType.Boolean && that.Type == ValType.Boolean)
            {
                // Boolean Comparison
                return this.BoolValue == that.BoolValue;
            }
            else if (this.Type == ValType.String && that.Type == ValType.String)
            {
                // String Comparison
                return this.StringValue.Equals(that.StringValue, StringComparison.Ordinal);
            }
            else if (this.Type == that.Type && (this.Type == ValType.Layer || this.Type == ValType.LoopType || this.Type == ValType.Origin))
            {
                // Comparison of other string-like types
                return this.StringValue.Equals(that.StringValue, StringComparison.Ordinal);
            }
            else
            {
                // everything else shouldn't be compared
                //throw new CompilerException(-1, 204, new String[] {Value.TypeToString(thisType), Value.TypeToString(thatType)});
                // TODO: Exception
                throw new Exception();
            }
        }



        public String ToString()
        {
            switch (type)
            {
                case ValType.Boolean: return BoolValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
                case ValType.Break: return "Break";
                case ValType.Double: return DoubleValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
                case ValType.Integer: return IntValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
                case ValType.Layer: return StringValue;
                case ValType.List: 
                    StringBuilder builder = new StringBuilder();
                    builder.Append("{");
                    for (int i = 0; i < ListValue.Count; i++) // Loop through all strings
                    {
                        builder.Append(ListValue[i].ToString()); // Append string to StringBuilder
                        if (i < ListValue.Count - 1)
                            builder.Append(",");
                    }
                    builder.Append("}");
                    string result = builder.ToString(); // Get string from StringBuilder
                    return ListValue.ToString();

                case ValType.LoopType: return StringValue;
                case ValType.Null: return "Null";
                case ValType.Object: return "Class";
                case ValType.Origin: return StringValue;
                case ValType.Return: return "Return";
                case ValType.String: return StringValue;
                case ValType.Void: return "Void";
                default: return "unknown";

            }
        }


        public String TypeString
        {
            get
            {
                switch (type)
                {
                    case ValType.Boolean: return "Boolean";
                    case ValType.Break: return "Break";
                    case ValType.Double: return "Double";
                    case ValType.Integer: return "Integer";
                    case ValType.Layer: return "Layer";
                    case ValType.List: return "List";
                    case ValType.LoopType: return "LoopType";
                    case ValType.Null: return "Null";
                    case ValType.Object: return "Object";
                    case ValType.Origin: return "Origin";
                    case ValType.Return: return "Return";
                    case ValType.String: return "String";
                    case ValType.Void: return "Void";
                    default: return "unknown";
                }
            }
        }

        /*
        public static String TypeToString(ValType type) {
            switch (type)
            {
                case ValType.Boolean: return "Boolean";
                case ValType.Break: return "Break";
                case ValType.Double: return "Double";
                case ValType.Integer: return "Integer";
                case ValType.Layer: return "Layer";
                case ValType.List: return "List";
                case ValType.LoopType: return "LoopType";
                case ValType.Null: return "Null";
                case ValType.Object: return "Object";
                case ValType.Origin: return "Origin";
                case ValType.Return: return "Return";
                case ValType.String: return "String";
                case ValType.Void: return "Void";
                default: return "unknown";
            }
        }*/

        /// <summary>
        /// TypeCompare method to ensure implizit convertion from int to float and vice versa.
        /// </summary>
        /// <param name="acceptedType">Type to compare with</param>
        /// <returns></returns>
        public bool TypeEquals(ValType acceptedType, bool exactType)
        {
            if (exactType) return type == acceptedType;
            else return TypeEquals(acceptedType);
        }

        public bool TypeEquals(ValType acceptedType)
        {
            switch (acceptedType)
            {
                case ValType.Integer:
                    return type == ValType.Integer || type == ValType.Double;
                case ValType.Double:
                    return type == ValType.Integer || type == ValType.Double;
                default:
                    return type == acceptedType;
            }
        }

        
        public static bool TypeCompare(List<Value> valueList, params ValType[] acceptedTypes)
        {
            if (valueList.Count != acceptedTypes.Length) return false;
            foreach (ValType type in acceptedTypes)
            {
                if (valueList.Type == type) return true;
            }
            return false;
        }

        public static string PrintTypeList(List<Value> valueList)
        {
            String output = "";
            for (int i = 0; i < valueList.Count; i++)
            {
                output += valueList[i].TypeString;
                if (i < valueList.Count - 1)
                {
                    output += ", ";
                }
            }
            return output;
        }


    }
}

