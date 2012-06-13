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

        private void InitializiseSpriteObject()
        {
            sprite =new SpriteObject(layer, origin, path);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterVisualObject(sprite);
        }

        /*
        private Value fade(double opacity, int startTime = 0, int endTime = 0, double endOpacity = 0, int easing = 0) {
            if (endOpacity == 0) endOpacity = opacity;
            double[] startParams = new double[] { opacity };
            double[] endParams = new double[] { endOpacity };
            sprite.AddCommand(new Animation(AnimationType.Fade, easing, startTime, endTime, startParams, endParams));
            return Value.VOID;
        }*/

        




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
    

                default: throw new CompilerException(-1, 314, Name, name);
            }
            //TODO: Exception
            throw new Exception();
        }

        public override string Name
        {
            get { return "Sprite"; }
        }

        // Private methods

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


    }
}
