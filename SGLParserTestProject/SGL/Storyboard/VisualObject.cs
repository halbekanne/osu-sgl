using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGL.Storyboard
{
    abstract class VisualObject
    {
        private List<Command> storyboardCommands;

        protected string layer;
        protected string origin;
        protected string filepath;

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
    }
}
