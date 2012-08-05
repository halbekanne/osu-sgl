using System;
using System.Collections.Generic;

using System.Text;
using SGL.Elements;

namespace SGL.Storyboard
{
    public abstract class VisualObject : IComparable
    {
        private List<Command> storyboardCommands = new List<Command>();

        protected string layer;
        protected string origin;
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

            foreach (Command command in storyboardCommands)
            {
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


        // Methods for Animation

        // 3 Parameter Methods
        // Coloring
        public void color(int easing, int startTime, int endTime, int startRed, int startGreen, int startBlue, int endRed, int endGreen, int endBlue)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startRed, startGreen, startBlue };
            double[] endParams = new double[] { endRed, endGreen, endBlue };
            this.AddCommand(new Animation(AnimationType.Color, easing, startTime, endTime, startParams, endParams));
        }

        public void color(int startTime, int endTime, int startRed, int startGreen, int startBlue, int endRed, int endGreen, int endBlue)
        {
            color(0, startTime, endTime, startRed, startGreen, startBlue, endRed, endGreen, endBlue);
        }

        public void color(int startTime, int startRed, int startGreen, int startBlue)
        {
            color(0, startTime, startTime, startRed, startGreen, startBlue, startRed, startGreen, startBlue);
        }

        public void color(int startRed, int startGreen, int startBlue)
        {
            color(0, 0, 0, startRed, startGreen, startBlue, startRed, startGreen, startBlue);
        }


        // 2 Parameter Methods
        // Moving
        public void move(int easing, int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startX, startY };
            double[] endParams = new double[] { endX, endY };
            this.AddCommand(new Animation(AnimationType.Move, easing, startTime, endTime, startParams, endParams));
        }

        public void move(int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            move(0, startTime, endTime, startX, startY, endX, endY);
        }

        public void move(int startTime, int startX, int startY)
        {
            move(0, startTime, startTime, startX, startY, startX, startY);
        }

        public void move(int startX, int startY)
        {
            move(0, 0, 0, startX, startY, startX, startY);
        }

        // Vector Scaling
        public void scaleVec(int easing, int startTime, int endTime, double startX, double startY, double endX, double endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startX, startY };
            double[] endParams = new double[] { endX, endY };
            this.AddCommand(new Animation(AnimationType.ScaleVec, easing, startTime, endTime, startParams, endParams));
        }

        public void scaleVec(int startTime, int endTime, double startX, double startY, double endX, double endY)
        {
            scaleVec(0, startTime, endTime, startX, startY, endX, endY);
        }

        public void scaleVec(int startTime, double startX, double startY)
        {
            scaleVec(0, startTime, startTime, startX, startY, startX, startY);
        }

        public void scaleVec(double startX, double startY)
        {
            scaleVec(0, 0, 0, startX, startY, startX, startY);
        }

        // 1 Parameter Methods
        // Fading
        public void fade(int easing, int startTime, int endTime, double startOpacity, double endOpacity)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startOpacity };
            double[] endParams = new double[] { endOpacity };
            this.AddCommand(new Animation(AnimationType.Fade, easing, startTime, endTime, startParams, endParams));
        }

        public void fade(int startTime, int endTime, double startOpacity, double endOpacity)
        {
            fade(0, startTime, endTime, startOpacity, endOpacity);
        }

        public void fade(int startTime, double startOpacity)
        {
            fade(0, startTime, startTime, startOpacity, startOpacity);
        }

        public void fade(double startOpacity)
        {
            fade(0, 0, 0, startOpacity, startOpacity);
        }

        // Scaling
        public void scale(int easing, int startTime, int endTime, double startScale, double endScale)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startScale };
            double[] endParams = new double[] { endScale };
            this.AddCommand(new Animation(AnimationType.Scale, easing, startTime, endTime, startParams, endParams));
        }

        public void scale(int startTime, int endTime, double startScale, double endScale)
        {
            scale(0, startTime, endTime, startScale, endScale);
        }

        public void scale(int startTime, double startScale)
        {
            scale(0, startTime, startTime, startScale, startScale);
        }

        public void scale(double startScale)
        {
            scale(0, 0, 0, startScale, startScale);
        }


        // Rotating
        public void rotate(int easing, int startTime, int endTime, double startAngle, double endAngle)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startAngle };
            double[] endParams = new double[] { endAngle };
            this.AddCommand(new Animation(AnimationType.Rotate, easing, startTime, endTime, startParams, endParams));
        }

        public void rotate(int startTime, int endTime, double startAngle, double endAngle)
        {
            rotate(0, startTime, endTime, startAngle, endAngle);
        }

        public void rotate(int startTime, double startAngle)
        {
            rotate(0, startTime, startTime, startAngle, startAngle);
        }

        public void rotate(double startAngle)
        {
            rotate(0, 0, 0, startAngle, startAngle);
        }


        // moveX
        public void moveX(int easing, int startTime, int endTime, double startX, double endX)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startX };
            double[] endParams = new double[] { endX };
            this.AddCommand(new Animation(AnimationType.MoveX, easing, startTime, endTime, startParams, endParams));
        }

        public void moveX(int startTime, int endTime, double startX, double endX)
        {
            moveX(0, startTime, endTime, startX, endX);
        }

        public void moveX(int startTime, double startX)
        {
            moveX(0, startTime, startTime, startX, startX);
        }

        public void moveX(double startX)
        {
            moveX(0, 0, 0, startX, startX);
        }


        // moveY
        public void moveY(int easing, int startTime, int endTime, double startY, double endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startY };
            double[] endParams = new double[] { endY };
            this.AddCommand(new Animation(AnimationType.MoveY, easing, startTime, endTime, startParams, endParams));
        }

        public void moveY(int startTime, int endTime, double startY, double endY)
        {
            moveY(0, startTime, endTime, startY, endY);
        }

        public void moveY(int startTime, double startY)
        {
            moveY(0, startTime, startTime, startY, startY);
        }

        public void moveY(double startY)
        {
            moveY(0, 0, 0, startY, startY);
        }



    }
}
