using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLValue : IComparable<SGLValue>
    {
        public static readonly SGLValue NULL = new SGLValue();
        public static readonly SGLValue VOID = new SGLValue();

        private Object value;

        private SGLValue()
        {
            // private constructor: only used for NULL and VOID  
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
            if (!(IsBoolean() || IsInteger() || IsFloat() || IsString()))
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
            try
            {
                return ((double)value);
            }
            catch
            {
                return ((double)this.AsInteger());
            }
        }

        public int AsInteger()
        {
            return ((int)value);
        }

        public String AsString()
        {
            return (String)value;
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

        public Boolean IsString()
        {
            return value is String;
        }

        public String ToString()
        {
            return IsNull() ? "NULL" : IsVoid() ? "VOID" : ((String)value);
        }

    }
}

