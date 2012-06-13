using System;
using System.Collections.Generic;

using System.Text;
using SGL.Storyboard;
using SGL.Elements;

namespace SGL.Library.Classes
{
    class Sprite : Class
    {
        private String layer = "Foreground";
        private String origin = "Centre";
        private String path;

        private SpriteObject sprite;

        // used for class registration
        public Sprite() { }

        private Sprite(String path)
        {
            this.path = path;
            InitializiseSpriteObject();
        }

        public override string Name
        {
            get { return "Sprite"; }
        }

        private void InitializiseSpriteObject()
        {
            sprite =new SpriteObject(layer, origin, path);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterVisualObject(sprite);
        }


        public override Class CreateObject(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.String)) return new Sprite(param[0].StringValue);
            else throw new CompilerException(-1, 312);
        }

        public override Value InvokeMethod(String name, List<Value> param)
        {
            switch (name) {
                case "fade":
                    if (Value.TypeCompare(param, ValType.Double))
                        return fade(param[0].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double)) 
                        return fade(param[0].IntValue, param[1].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return fade(param[0].IntValue, param[1].IntValue, param[2].DoubleValue, param[3].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return fade(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].DoubleValue, param[4].DoubleValue);
                    else 
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "scale":
                    if (Value.TypeCompare(param, ValType.Double))
                        return scale(param[0].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                        return scale(param[0].IntValue, param[1].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return scale(param[0].IntValue, param[1].IntValue, param[2].DoubleValue, param[3].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return scale(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].DoubleValue, param[4].DoubleValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "rotate":
                    if (Value.TypeCompare(param, ValType.Double))
                        return rotate(param[0].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                        return rotate(param[0].IntValue, param[1].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return rotate(param[0].IntValue, param[1].IntValue, param[2].DoubleValue, param[3].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return rotate(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].DoubleValue, param[4].DoubleValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "moveX":
                    if (Value.TypeCompare(param, ValType.Double))
                        return moveX(param[0].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                        return moveX(param[0].IntValue, param[1].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return moveX(param[0].IntValue, param[1].IntValue, param[2].DoubleValue, param[3].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return moveX(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].DoubleValue, param[4].DoubleValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "moveY":
                    if (Value.TypeCompare(param, ValType.Double))
                        return moveY(param[0].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                        return moveY(param[0].IntValue, param[1].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return moveY(param[0].IntValue, param[1].IntValue, param[2].DoubleValue, param[3].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                        return moveY(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].DoubleValue, param[4].DoubleValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "move":
                    if (Value.TypeCompare(param, ValType.Integer, ValType.Integer))
                        return move(param[0].IntValue, param[1].IntValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer))
                        return move(param[0].IntValue, param[1].IntValue, param[2].IntValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                        return move(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue, param[4].IntValue, param[5].IntValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                        return move(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue, param[4].IntValue, param[5].IntValue, param[6].IntValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "scaleVec":
                    if (Value.TypeCompare(param, ValType.Double, ValType.Double))
                        return scaleVec(param[0].DoubleValue, param[1].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double, ValType.Double))
                        return scaleVec(param[0].IntValue, param[1].DoubleValue, param[2].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double, ValType.Double, ValType.Double))
                        return scaleVec(param[0].IntValue, param[1].IntValue, param[2].DoubleValue, param[3].DoubleValue, param[4].DoubleValue, param[5].DoubleValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double, ValType.Double, ValType.Double))
                        return scaleVec(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].DoubleValue, param[4].DoubleValue, param[5].DoubleValue, param[6].DoubleValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "color":
                    if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer))
                        return color(param[0].IntValue, param[1].IntValue, param[2].IntValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                        return color(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                        return color(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue, param[4].IntValue, param[5].IntValue, param[6].IntValue, param[7].IntValue);
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                        return color(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue, param[4].IntValue, param[5].IntValue, param[6].IntValue, param[7].IntValue, param[8].IntValue);
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));
    

                default: throw new CompilerException(-1, 314, Name, name);
            }
            //TODO: Exception
            throw new Exception();
        }


        // Private methods

        // 3 Parameter Methods
        // Coloring
        private Value color(int easing, int startTime, int endTime, int startRed, int startGreen, int startBlue, int endRed, int endGreen, int endBlue)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startRed, startGreen, startBlue };
            double[] endParams = new double[] { endRed, endGreen, endBlue };
            sprite.AddCommand(new Animation(AnimationType.Color, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value color(int startTime, int endTime, int startRed, int startGreen, int startBlue, int endRed, int endGreen, int endBlue)
        {
            return color(0, startTime, endTime, startRed, startGreen, startBlue, endRed, endGreen, endBlue);
        }

        private Value color(int startTime, int startRed, int startGreen, int startBlue)
        {
            return color(0, startTime, startTime, startRed, startGreen, startBlue, startRed, startGreen, startBlue);
        }

        private Value color(int startRed, int startGreen, int startBlue)
        {
            return color(0, 0, 0, startRed, startGreen, startBlue, startRed, startGreen, startBlue);
        }


        // 2 Parameter Methods
        // Moving
        private Value move(int easing, int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startX, startY };
            double[] endParams = new double[] { endX, endY };
            sprite.AddCommand(new Animation(AnimationType.Move, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value move(int startTime, int endTime, int startX, int startY, int endX, int endY)
        {
            return move(0, startTime, endTime, startX, startY, endX, endY);
        }

        private Value move(int startTime, int startX, int startY)
        {
            return move(0, startTime, startTime, startX, startY, startX, startY);
        }

        private Value move(int startX, int startY)
        {
            return move(0, 0, 0, startX, startY, startX, startY);
        }

        // Vector Scaling
        private Value scaleVec(int easing, int startTime, int endTime, double startX, double startY, double endX, double endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startX, startY };
            double[] endParams = new double[] { endX, endY };
            sprite.AddCommand(new Animation(AnimationType.ScaleVec, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value scaleVec(int startTime, int endTime, double startX, double startY, double endX, double endY)
        {
            return scaleVec(0, startTime, endTime, startX, startY, endX, endY);
        }

        private Value scaleVec(int startTime, double startX, double startY)
        {
            return scaleVec(0, startTime, startTime, startX, startY, startX, startY);
        }

        private Value scaleVec(double startX, double startY)
        {
            return scaleVec(0, 0, 0, startX, startY, startX, startY);
        }

        // 1 Parameter Methods
        // Fading
        private Value fade(int easing, int startTime, int endTime, double startOpacity, double endOpacity)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startOpacity };
            double[] endParams = new double[] { endOpacity };
            sprite.AddCommand(new Animation(AnimationType.Fade, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value fade(int startTime, int endTime, double startOpacity, double endOpacity)
        {
            return fade(0, startTime, endTime, startOpacity, endOpacity);
        }

        private Value fade(int startTime, double startOpacity)
        {
            return fade(0, startTime, startTime, startOpacity, startOpacity);
        }

        private Value fade(double startOpacity)
        {
            return fade(0, 0, 0, startOpacity, startOpacity);
        }

        // Scaling
        private Value scale(int easing, int startTime, int endTime, double startScale, double endScale)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startScale };
            double[] endParams = new double[] { endScale };
            sprite.AddCommand(new Animation(AnimationType.Scale, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value scale(int startTime, int endTime, double startScale, double endScale)
        {
            return scale(0, startTime, endTime, startScale, endScale);
        }

        private Value scale(int startTime, double startScale)
        {
            return scale(0, startTime, startTime, startScale, startScale);
        }

        private Value scale(double startScale)
        {
            return scale(0, 0, 0, startScale, startScale);
        }


        // Rotating
        private Value rotate(int easing, int startTime, int endTime, double startAngle, double endAngle)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startAngle };
            double[] endParams = new double[] { endAngle };
            sprite.AddCommand(new Animation(AnimationType.Rotate, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value rotate(int startTime, int endTime, double startAngle, double endAngle)
        {
            return rotate(0, startTime, endTime, startAngle, endAngle);
        }

        private Value rotate(int startTime, double startAngle)
        {
            return rotate(0, startTime, startTime, startAngle, startAngle);
        }

        private Value rotate(double startAngle)
        {
            return rotate(0, 0, 0, startAngle, startAngle);
        }


        // moveX
        private Value moveX(int easing, int startTime, int endTime, double startX, double endX)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startX };
            double[] endParams = new double[] { endX };
            sprite.AddCommand(new Animation(AnimationType.MoveX, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value moveX(int startTime, int endTime, double startX, double endX)
        {
            return moveX(0, startTime, endTime, startX, endX);
        }

        private Value moveX(int startTime, double startX)
        {
            return moveX(0, startTime, startTime, startX, startX);
        }

        private Value moveX(double startX)
        {
            return moveX(0, 0, 0, startX, startX);
        }


        // moveY
        private Value moveY(int easing, int startTime, int endTime, double startY, double endY)
        {
            if (easing < 0 || easing > 2) throw new CompilerException(-1, 315, easing.ToString());
            double[] startParams = new double[] { startY };
            double[] endParams = new double[] { endY };
            sprite.AddCommand(new Animation(AnimationType.MoveY, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }

        private Value moveY(int startTime, int endTime, double startY, double endY)
        {
            return moveY(0, startTime, endTime, startY, endY);
        }

        private Value moveY(int startTime, double startY)
        {
            return moveY(0, startTime, startTime, startY, startY);
        }

        private Value moveY(double startY)
        {
            return moveY(0, 0, 0, startY, startY);
        }


    }
}
