using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLObject : IComparable 
    {
        protected int priority;
        protected SGLValue filepath;
        protected SGLValue layer;
        protected SGLValue origin;
        protected StringBuilder objectSbCode = new StringBuilder();

        public int GetPriority()
        {
            return priority;
        }

        public SGLValue GetFilepath()
        {
            return filepath;
        }

        public SGLValue GetLayer()
        {
            return layer;
        }

        public SGLValue GetOrigin()
        {
            return origin;
        }


        public int CompareTo(Object o)
        {
            if (o is SGLObject)
            {
                return this.GetPriority() - ((SGLObject)o).GetPriority();
            }
            else
            {
                throw new Exception("SGLObject can't be compared");
            }

        }

        public void AddSbCode(String sbCode)
        {
            objectSbCode.AppendLine(sbCode);
            Console.WriteLine("Added code:" + sbCode);
        }


    }
}
