using System;
using System.Collections.Generic;
using System.Text;
using SGLOld.Types;
using System.ComponentModel;

namespace SGLOld
{

    public class Value : IComparable<Value>
    {
        public static readonly Value NULL = new Value();
        public static readonly Value VOID = new Value();
        public static readonly Value BREAK = new Value();
        public static readonly Value INVALID = new Value();

        private Object value;

        private Value()
        {
            // private constructor: only used for NULL, VOID and BREAK
            value = new Object();
        }


        public Value(Object v)
        {
            if (v == null)
            {
                throw new Exception("v == null");
            }

            value = v;
            
            // only accept boolean, number or string types  
            if (!(IsBoolean() || IsInteger() || IsFloat() || IsString() || IsList() || IsObject() || IsReturn()))
            {
                throw new Exception("invalid type: " + v + " (" + v.GetType() + ")");
            }

            if (IsString())
            {
                String newString = AsString();
                newString = newString.Replace("\\\\", "\\");
                newString = newString.Replace("\\\"", "\"");
                value = newString;
            }

            
        }

        public Boolean AsBoolean()
        {
            return (Boolean)value;
        }

        public Double AsFloat()
        {

            if (IsFloat())
            {
                return ((double)value);
            }
            else if (IsInteger())
            {
                return ((double)this.AsInteger());
            }

            throw new Exception("Value can't be converted to a float value");

            /*
            try
            {
                return ((double)value);
            }
            catch (System.InvalidCastException)
            {
                return ((double)this.AsInteger());
            }
             * */
        }

        public int AsInteger()
        {
            return (int)value;
        }

        public String AsString()
        {
            return (String)value;
        }

        public List<Value> AsList()
        {
            return (List<Value>)value;
        }

        public ReturnValue AsReturn()
        {
            return TypeDescriptor.GetConverter(typeof(ReturnValue)).ConvertTo(value, typeof(ReturnValue));
            return (ReturnValue)value;
        }

        public SpriteObject AsObject()
        {
            try
            {
                return (SpriteObject)value;
            }
            catch (InvalidCastException ice)
            {
                if (IsString() && AsString().Equals("undefined"))
                {
                    throw new CompilerException(-1, "undeclared object", "");
                }
                else
                {
                    throw new CompilerException(-1, "type mismatch", value.ToString() + "");
                }
            }
        }

        // Compare one value to another
        public int CompareTo(Value that)
        {
            if (this.IsInteger() && that.IsInteger())
            {
                if (this.Equals(that))
                {
                    return 0;
                }
                else
                {
                    return this.AsInteger().CompareTo(that.AsInteger());
                }
            }
            else if (this.IsNumber() && that.IsNumber())
            {
                if (this.Equals(that))
                {
                    return 0;
                }
                else
                {
                    return this.AsFloat().CompareTo(that.AsFloat());
                }
            }
            else if (this.IsString() && that.IsString())
            {
                return this.AsString().CompareTo(that.AsString());
            }
            else
            {
                throw new Exception("illegal expression: can't compare `" +
                    this + "` to `" + that + "`");
            }
        }

        // Checks if one value is the same as another value
        public override Boolean Equals(Object o)
        {
            ValueType thisType = this.GetType();
            Value that = (Value)o;
            ValueType thatType = that.GetType();
            

            if (thisType == ValueType.Float || thatType == ValueType.Float)
            {
                // Float Comparison
                double diff = Math.Abs(this.AsFloat() - that.AsFloat());
                return diff < 0.00000000001;
            }
            else if (thisType == ValueType.Integer && thatType == ValueType.Integer)
            {
                // Integer Comparison
                return this.AsInteger() == that.AsInteger();
            }
            else if (thisType == ValueType.Boolean && thatType == ValueType.Boolean)
            {
                // Boolean Comparison
                return this.AsBoolean() == that.AsBoolean();
            }
            else if (thisType == ValueType.String && thatType == ValueType.String)
            {
                // String Comparison
                return this.AsString().Equals(that.AsString(), StringComparison.Ordinal);
            }
            else if (thisType == thatType && (thisType == ValueType.Layer || thisType == ValueType.LoopType || thisType == ValueType.Origin))
            {
                // Comparison of other string-like types
                return this.AsString().Equals(that.AsString(), StringComparison.Ordinal);
            }
            else
            {
                // everything else shouldn't be compared
                throw new CompilerException(-1, 204, new String[] {Value.TypeToString(thisType), Value.TypeToString(thatType)});
            }
        }

        public Boolean IsBoolean()
        {
            return value is Boolean;
        }

        public Boolean IsNumber()
        {
            return IsInteger() || IsFloat();
        }

        public Boolean IsInteger()
        {
            return value is int;
        }

        public Boolean IsFloat()
        {
            return value is Double;
        }

        public Boolean IsNull()
        {
            return this == NULL;
        }

        public Boolean IsVoid()
        {
            return this == VOID;
        }

        public Boolean IsBreak()
        {
            return this == BREAK;
        }

        public Boolean IsString()
        {
            return value is String;
        }

        public Boolean IsList()
        {
            return value is List<Value>;
        }

        public Boolean IsSprite()
        {
            return value is Sprite;
        }

        public Boolean IsObject()
        {
            return value is SpriteObject;
        }

        public Boolean IsOrigin()
        {
            try
            {
                String origin = AsString();
                switch (origin)
                {
                    case "TopLeft": return true;
                    case "TopCentre": return true;
                    case "TopRight": return true;
                    case "CentreLeft": return true;
                    case "Centre": return true;
                    case "CentreRight": return true;
                    case "BottomLeft": return true;
                    case "BottomCentre": return true;
                    case "BottomRight": return true;
                    default: return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean IsLayer()
        {
            try
            {
                String layer = AsString();
                switch (layer)
                {
                    case "Background": return true;
                    case "Fail": return true;
                    case "Pass": return true;
                    case "Foreground": return true;
                    default: return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean IsLoopType()
        {
            try
            {
                String loopType = AsString();
                switch (loopType)
                {
                    case "LoopForever": return true;
                    case "LoopOnce": return true;
                    default: return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public Boolean IsReturn()
        {
            return value is ReturnValue;
        }

        public ValueType GetType()
        {
            if (IsNull())
            {
                return ValueType.Null;
            }
            else if (IsVoid())
            {
                return ValueType.Void;
            }
            else if (IsBreak())
            {
                return ValueType.Break;
            }
            else if (IsReturn())
            {
                return ValueType.Return;
            }
            else if (IsInteger())
            {
                return ValueType.Integer;
            }
            else if (IsFloat())
            {
                return ValueType.Float;
            }
            else if (IsBoolean())
            {
                return ValueType.Boolean;
            }
            else if (IsObject())
            {
                return ValueType.Object;
            }
            else if (IsLayer())
            {
                return ValueType.Layer;
            }
            else if (IsOrigin())
            {
                return ValueType.Origin;
            }
            else if (IsLoopType())
            {
                return ValueType.LoopType;
            }
            else if (IsList())
            {
                return ValueType.List;
            }
            else if (IsString())
            {
                return ValueType.String;
            }
            throw new Exception("Unknown Type");
        }


        public String ToString()
        {
            switch (GetType())
            {
                case ValueType.Boolean: return AsBoolean().ToString(System.Globalization.CultureInfo.InvariantCulture);
                case ValueType.Break: return "Break";
                case ValueType.Float: return AsFloat().ToString(System.Globalization.CultureInfo.InvariantCulture);
                case ValueType.Integer: return AsInteger().ToString(System.Globalization.CultureInfo.InvariantCulture);
                case ValueType.Layer: return AsString();
                case ValueType.List: 
                    StringBuilder builder = new StringBuilder();
                    builder.Append("{");
                    for (int i = 0; i < AsList().Count; i++) // Loop through all strings
                    {
                        builder.Append(AsList()[i].ToString()); // Append string to StringBuilder
                        if (i < AsList().Count - 1)
                            builder.Append(",");
                    }
                    builder.Append("}");
                    string result = builder.ToString(); // Get string from StringBuilder
                    return AsList().ToString();

                case ValueType.LoopType: return AsString();
                case ValueType.Null: return "Null";
                case ValueType.Object: return "Object";
                case ValueType.Origin: return AsString();
                case ValueType.Return: return "Return";
                case ValueType.String: return AsString();
                case ValueType.Void: return "Void";
                default: return "unknown";

            }
        }


        public static String TypeToString(ValueType type) {
            switch (type)
            {
                case ValueType.Boolean: return "Boolean";
                case ValueType.Break: return "Break";
                case ValueType.Float: return "Float";
                case ValueType.Integer: return "Integer";
                case ValueType.Layer: return "Layer";
                case ValueType.List: return "List";
                case ValueType.LoopType: return "LoopType";
                case ValueType.Null: return "Null";
                case ValueType.Object: return "Object";
                case ValueType.Origin: return "Origin";
                case ValueType.Return: return "Return";
                case ValueType.String: return "String";
                case ValueType.Void: return "Void";
                default: return "unknown";
            }
        }


    }
}

