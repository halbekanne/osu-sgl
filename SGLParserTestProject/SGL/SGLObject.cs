using System;
using System.Collections.Generic;
using System.Text;

namespace SGL
{
    public class SGLObject : IComparable 
    {
        protected int priority;
        protected String filepath;
        protected String layer;
        protected String origin;
        protected StringBuilder objectSbCode = new StringBuilder();

        // Lists of commands
        public List<SbCommand> moveCmds = new List<SbCommand>();
        public List<SbCommand> moveXCmds = new List<SbCommand>();
        public List<SbCommand> moveYCmds = new List<SbCommand>();
        public List<SbCommand> fadeCmds = new List<SbCommand>();
        public List<SbCommand> rotateCmds = new List<SbCommand>();
        public List<SbCommand> scaleCmds = new List<SbCommand>();
        public List<SbCommand> colorCmds = new List<SbCommand>();

        public int GetPriority()
        {
            return priority;
        }

        public String GetFilepath()
        {
            return filepath;
        }

        public String GetLayer()
        {
            return layer;
        }

        public String GetOrigin()
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
        }

    }
}
