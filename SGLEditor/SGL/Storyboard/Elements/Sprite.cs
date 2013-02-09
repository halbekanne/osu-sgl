using SGL.Elements;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Storyboard
{
    public class Sprite : IComparable
    {
        private readonly List<Command> storyboardCommands = new List<Command>();
        protected string filepath;

        protected string layer;
        protected string origin;
        protected int priority = 0;

        protected int x = 320;
        protected int y = 240;
        protected double scaleFactor = 1;

<<<<<<< HEAD:SGLParserTestProject/SGL/Storyboard/Elements/Sprite.cs
        public Sprite()
        {

        }

        public Sprite(string layer, string origin, string filepath)
=======

        public int X
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Storyboard/VisualObject.cs
        {
            get
            {
                return x;
            }
        }

<<<<<<< HEAD:SGLParserTestProject/SGL/Storyboard/Elements/Sprite.cs

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public double Scale
        {
            get
            {
                return scaleFactor;
            }
        }

=======
        public int Y
        {
            get
            {
                return y;
            }
        }

        public double Scale
        {
            get
            {
                return scaleFactor;
            }
        }

        public VisualObject()
        {

        }

        public VisualObject(string layer, string origin, string filepath)
        {
            this.layer = layer;
            this.origin = origin;
            this.filepath = filepath;
        }

>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Storyboard/VisualObject.cs
        public int Priority
        {
            get { return priority; }
        }

        #region IComparable Members

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            // sort order: 1. layer, 2. priority
<<<<<<< HEAD:SGLParserTestProject/SGL/Storyboard/Elements/Sprite.cs
            var that = obj as Sprite;
=======
            var that = obj as VisualObject;
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Storyboard/VisualObject.cs
            if (that != null)
            {
                int layerCompare = LayerToInt().CompareTo(that.LayerToInt());
                if (layerCompare != 0) return layerCompare;
                else
                {
                    return Priority.CompareTo(that.Priority);
                }
            }
            else
                throw new ArgumentException("Object is not a Sprite");
        }

        #endregion

        /// <summary>
<<<<<<< HEAD:SGLParserTestProject/SGL/Storyboard/Elements/Sprite.cs
        /// Generates the storyboard code for one Sprite
=======
        /// Generates the storyboard code for one VisualObject
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Storyboard/VisualObject.cs
        /// </summary>
        /// <param name="storyboardCode"></param>
        public virtual void GenerateSbCode(StringBuilder storyboardCode)
        {
            // Start Sprite with this code
            String initCode = GetStoryboardInitCode();
            if (initCode != null)
            {
                storyboardCode.AppendLine(initCode);
            }

            foreach (Command command in storyboardCommands)
            {
                command.AddSoryboardCode(storyboardCode);
            }
        }

<<<<<<< HEAD:SGLParserTestProject/SGL/Storyboard/Elements/Sprite.cs
        protected virtual String GetStoryboardInitCode()
        {
            return "Sprite," + layer + "," + origin + ",\"" + filepath + "\",320,240";
        }

        public void AddCommand(Command command)
        {
            storyboardCommands.Add(command);
        }

=======
        public void AddCommand(Command command)
        {
            storyboardCommands.Add(command);
        }

        protected abstract String GetStoryboardInitCode();

>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Storyboard/VisualObject.cs
        public int LayerToInt()
        {
            switch (layer)
            {
                case "Background":
                    return 0;
                case "Fail":
                    return 1;
                case "Pass":
                    return 2;
                case "Foreground":
                    return 3;
                default:
                    throw new Exception("unknown layer type");
            }
        }


        // Methods for Animation

        // 3 Parameter Methods
        // Coloring
        public virtual void color(int easing, int startTime, int endTime, int startRed, int startGreen, int startBlue,
                          int endRed, int endGreen, int endBlue)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new double[] {startRed, startGreen, startBlue};
            var endParams = new double[] {endRed, endGreen, endBlue};
            AddCommand(new Animation(AnimationType.Color, easing, startTime, endTime, startParams, endParams));
        }

        public void color(int startTime, int endTime, int startRed, int startGreen, int startBlue, int endRed,
                          int endGreen, int endBlue)
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
        public virtual void move(int easing, int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new double[] {startX, startY};
            var endParams = new double[] {endX, endY};
            AddCommand(new Animation(AnimationType.Move, easing, startTime, endTime, startParams, endParams));
            this.x = endX;
            this.y = endY;
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
        public virtual void scaleVec(int easing, int startTime, int endTime, double startX, double startY, double endX,
                             double endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new[] {startX, startY};
            var endParams = new[] {endX, endY};
            AddCommand(new Animation(AnimationType.ScaleVec, easing, startTime, endTime, startParams, endParams));
            this.scaleFactor = (endX + endY) / 2;
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
        public virtual void fade(int easing, int startTime, int endTime, double startOpacity, double endOpacity)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new[] {startOpacity};
            var endParams = new[] {endOpacity};
            AddCommand(new Animation(AnimationType.Fade, easing, startTime, endTime, startParams, endParams));
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
        public virtual void scale(int easing, int startTime, int endTime, double startScale, double endScale)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new[] {startScale};
            var endParams = new[] {endScale};
            AddCommand(new Animation(AnimationType.Scale, easing, startTime, endTime, startParams, endParams));
            this.scaleFactor = endScale;
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
        public virtual void rotate(int easing, int startTime, int endTime, double startAngle, double endAngle)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new[] {startAngle};
            var endParams = new[] {endAngle};
            AddCommand(new Animation(AnimationType.Rotate, easing, startTime, endTime, startParams, endParams));
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
        public virtual void moveX(int easing, int startTime, int endTime, double startX, double endX)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new[] {startX};
            var endParams = new[] {endX};
            AddCommand(new Animation(AnimationType.MoveX, easing, startTime, endTime, startParams, endParams));
            this.x = (int)endX;
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
        public virtual void moveY(int easing, int startTime, int endTime, double startY, double endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            var startParams = new[] {startY};
            var endParams = new[] {endY};
            AddCommand(new Animation(AnimationType.MoveY, easing, startTime, endTime, startParams, endParams));
            this.y = (int)endY;
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
<<<<<<< HEAD:SGLParserTestProject/SGL/Storyboard/Elements/Sprite.cs


=======
>>>>>>> acd057c2e1cb7c9ab7790ac768f8e71ba04f5e58:SGLParserTestProject/SGL/Storyboard/VisualObject.cs
    }
}