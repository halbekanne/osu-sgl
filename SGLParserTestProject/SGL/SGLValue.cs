using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLValue : IComparable<SGLValue>
    {
        public static readonly SGLValue NULL = new SGLValue();
        public static readonly SGLValue VOID = new SGLValue();
        public static readonly SGLValue BREAK = new SGLValue();

        private Object value;

        private SGLValue()
        {
            // private constructor: only used for NULL, VOID and BREAK
            value = new Object();
        }


        public SGLValue(Object v)
        {
            if (v == null)
            {
                throw new Exception("v == null");
            }
            value = v;
            /*
            if (value is Double)
            {
                Console.WriteLine(((Double)value).ToString());
                //value = System.Convert.ToDouble((float)value);
                //double test = System.Convert.ToDouble((float)value);
            }
            */
            // only accept boolean, number or string types  
            if (!(IsBoolean() || IsInteger() || IsFloat() || IsString() || IsObject()))
            {
                throw new Exception("invalid type: " + v + " (" + v.GetType() + ")");
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
            return ((int)value);
        }

        public String AsString()
        {
            return (String)value;
        }

        public SGLObject AsObject()
        {
            return (SGLObject)value;
        }

        // Compare one value to another
        public int CompareTo(SGLValue that)
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
        public Boolean Equals(Object o)
        {
            if (this == VOID || o == VOID)
            {
                throw new Exception("can't use VOID: " + this + " ==/!= " + o);
            }
            if (this == o)
            {
                return true;
            }
            if (o == null || this.GetType() != o.GetType())
            {
                return false;
            }
            SGLValue that = (SGLValue)o;
            if (this.IsInteger() && that.IsInteger())
            {
                return this.AsInteger() == that.AsInteger();
            }
            if (this.IsFloat() && that.IsFloat())
            {
                double diff = Math.Abs(this.AsFloat() - that.AsFloat());
                return diff < 0.00000000001;
            }
            else
            {
                return this.value.Equals(that.value);
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

        public Boolean IsSprite()
        {
            return value is Sprite;
        }

        public Boolean IsObject()
        {
            return value is SGLObject;
        }

        public Boolean IsOrigin()
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

        public Boolean IsLayer()
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


        public String GetVarType()
        {
            if (IsNull())
            {
                return "NULL";
            }
            else if (IsVoid())
            {
                return "VOID";
            }
            else if (IsBreak())
            {
                return "Break";
            }
            else if (IsInteger())
            {
                return "int";
            }
            else if (IsFloat())
            {
                return "float";
            }
            else if (IsBoolean())
            {
                return "boolean";
            }
            else if (IsString())
            {
                return "string";
            }
            throw new Exception("Unknown Type");
        }


        public String ToString()
        {
            if (IsNull())
            {
                return "NULL";
            }
            else if (IsVoid())
            {
                return "VOID";
            }
            else if (IsBreak())
            {
                return "Break";
            }
            else if (IsInteger())
            {
                return AsInteger().ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (IsFloat())
            {
                return AsFloat().ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
            else if (IsBoolean())
            {
                return AsBoolean().ToString(System.Globalization.CultureInfo.InvariantCulture);
            }
            else
            {
                return value.ToString();
            }
        }

    }
}

