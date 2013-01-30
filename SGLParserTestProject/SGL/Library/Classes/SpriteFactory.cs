using System;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Storyboard;

namespace SGL.Library.Classes
{
    internal class SpriteFactory : Visual
    {
        protected Sprite Sprite;

        public Sprite Object
        {
            get
            {
                return Sprite;
            }
        }

        private readonly String layer;
        private readonly String origin;
        private readonly String path;

        //private SpriteObject sprite;

        // used for class registration
        public SpriteFactory()
        {
        }

        private SpriteFactory(String path)
            : this(path, "Foreground", "Centre")
        {
        }

        private SpriteFactory(String path, String layer)
            : this(path, layer, "Centre")
        {
        }

        private SpriteFactory(String path, String layer, String origin)
        {
            this.path = path;
            this.layer = layer;
            this.origin = origin;
            InitializiseSpriteObject();
        }

        public override string Name
        {
            get { return "Sprite"; }
        }

        private void InitializiseSpriteObject()
        {
            Sprite = new SpriteFactory(layer, origin, path);
            // we need to save this object in order to generate the storyboard when all parsing processes finished
            GlobalMemory.Instance.RegisterSprite(Sprite);
        }


        public override object CreateNewInstance(List<Value> param)
        {
            if (Value.TypeCompare(param, ValType.String)) return new SpriteFactory(param[0].StringValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer))
                return new SpriteFactory(param[0].StringValue, param[1].StringValue);
            else if (Value.TypeCompare(param, ValType.String, ValType.Layer, ValType.Origin))
                return new SpriteFactory(param[0].StringValue, param[1].StringValue, param[2].StringValue);
            else throw new CompilerException(-1, 312);
        }

        public override Value InvokeMethod(String name, List<Value> param)
        {
            switch (name)
            {
                case "fade":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        Sprite.fade(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        Sprite.fade(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        Sprite.fade(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                          param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        Sprite.fade(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                          param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "scale":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        Sprite.scale(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        Sprite.scale(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        Sprite.scale(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                           param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        Sprite.scale(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "rotate":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        Sprite.rotate(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        Sprite.rotate(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        Sprite.rotate(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                            param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        Sprite.rotate(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                            param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "moveX":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        Sprite.moveX(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        Sprite.moveX(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        Sprite.moveX(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                           param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        Sprite.moveX(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "moveY":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        Sprite.moveY(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        Sprite.moveY(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        Sprite.moveY(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                           param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        Sprite.moveY(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "move":
                    if (Value.TypeCompare(param, ValType.Integer, ValType.Integer))
                    {
                        Sprite.move(param[0].IntValue, param[1].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        Sprite.move(param[0].IntValue, param[1].IntValue, param[2].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer))
                    {
                        Sprite.move(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue,
                                          param[4].IntValue, param[5].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        Sprite.move(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                          param[3].IntValue, param[4].IntValue, param[5].IntValue,
                                          param[6].IntValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "scaleVec":
                    if (Value.TypeCompare(param, ValType.Double, ValType.Double))
                    {
                        Sprite.scaleVec(param[0].DoubleValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        Sprite.scaleVec(param[0].IntValue, param[1].DoubleValue, param[2].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double,
                                               ValType.Double, ValType.Double))
                    {
                        Sprite.scaleVec(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                              param[3].DoubleValue, param[4].DoubleValue, param[5].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Double, ValType.Double, ValType.Double, ValType.Double))
                    {
                        Sprite.scaleVec(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                              param[3].DoubleValue, param[4].DoubleValue, param[5].DoubleValue,
                                              param[6].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "color":
                    if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        Sprite.color(param[0].IntValue, param[1].IntValue, param[2].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        Sprite.color(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer))
                    {
                        Sprite.color(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].IntValue, param[4].IntValue, param[5].IntValue,
                                           param[6].IntValue, param[7].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer))
                    {
                        Sprite.color(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].IntValue, param[4].IntValue, param[5].IntValue,
                                           param[6].IntValue, param[7].IntValue, param[8].IntValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));


                default:
                    throw new CompilerException(-1, 314, Name, name);
            }
            //TODO: Exception
            throw new Exception();
        }
    }
}