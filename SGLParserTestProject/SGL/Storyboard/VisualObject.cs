using System;
using System.Collections.Generic;

using System.Text;

namespace SGL.Storyboard
{
    public abstract class VisualObject : IComparable
    {
        private List<Command> storyboardCommands = new List<Command>();

        protected string layer = "Foreground";
        protected string origin = "Centre";
        protected string filepath;
        protected int priority = 0;

        public VisualObject(string layer, string origin, string filepath)
        {
            this.layer = layer;
            this.origin = origin;
            this.filepath = filepath;
        }

        /// <summary>
        /// Generates the storyboard code for one VisualObject
        /// </summary>
        /// <param name="storyboardCode"></param>
        public void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            storyboardCode.AppendLine(GetStoryboardInitCode());

            foreach (Command command in storyboardCommands) {
                command.AddSoryboardCode(storyboardCode);
            }
        }

        public void AddCommand(Command command)
        {
            storyboardCommands.Add(command);
        }

        protected abstract String GetStoryboardInitCode();

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            // sort order: 1. layer, 2. priority
            VisualObject that = obj as VisualObject;
            if (that != null)
            {
                int layerCompare = this.LayerToInt().CompareTo(that.LayerToInt());
                if (layerCompare != 0) return layerCompare;
                else
                {
                    return this.Priority.CompareTo(that.Priority);
                }
            } 
            else
                throw new ArgumentException("Object is not a VisualObject");
        }

        public int LayerToInt()
        {
            switch (this.layer)
            {
                case "Background": return 0;
                case "Fail": return 1;
                case "Pass": return 2;
                case "Foreground": return 3;
                default: throw new Exception("unknown layer type");
            }
        }

        public int Priority
        {
            get
            {
                return priority;
            }
        }
    }
}
