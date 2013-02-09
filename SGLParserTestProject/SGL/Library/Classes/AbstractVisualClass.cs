using System;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Storyboard.Generators.Visual;

namespace SGL.Library.Classes
{
    public abstract class AbstractVisualClass : AbstractClass
    {
        protected AbstractVisualGenerator visualObject;

        public AbstractVisualGenerator Object
        {
            get
            {
                return visualObject;
            }
        }

        public override Value InvokeMethod(String name, List<Value> param)
        {
            switch (name)
            {
                case "fade":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        visualObject.fade(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        visualObject.fade(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        visualObject.fade(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                          param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        visualObject.fade(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                          param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "scale":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        visualObject.scale(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        visualObject.scale(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        visualObject.scale(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                           param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        visualObject.scale(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "rotate":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        visualObject.rotate(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        visualObject.rotate(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        visualObject.rotate(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                            param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        visualObject.rotate(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                            param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "moveX":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        visualObject.moveX(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        visualObject.moveX(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        visualObject.moveX(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                           param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        visualObject.moveX(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "moveY":
                    if (Value.TypeCompare(param, ValType.Double))
                    {
                        visualObject.moveY(param[0].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double))
                    {
                        visualObject.moveY(param[0].IntValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        visualObject.moveY(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                           param[3].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Double,
                                               ValType.Double))
                    {
                        visualObject.moveY(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].DoubleValue, param[4].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "move":
                    if (Value.TypeCompare(param, ValType.Integer, ValType.Integer))
                    {
                        visualObject.move(param[0].IntValue, param[1].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        visualObject.move(param[0].IntValue, param[1].IntValue, param[2].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer))
                    {
                        visualObject.move(param[0].IntValue, param[1].IntValue, param[2].IntValue, param[3].IntValue,
                                          param[4].IntValue, param[5].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        visualObject.move(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                          param[3].IntValue, param[4].IntValue, param[5].IntValue,
                                          param[6].IntValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "scaleVec":
                    if (Value.TypeCompare(param, ValType.Double, ValType.Double))
                    {
                        visualObject.scaleVec(param[0].DoubleValue, param[1].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Double, ValType.Double))
                    {
                        visualObject.scaleVec(param[0].IntValue, param[1].DoubleValue, param[2].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Double, ValType.Double,
                                               ValType.Double, ValType.Double))
                    {
                        visualObject.scaleVec(param[0].IntValue, param[1].IntValue, param[2].DoubleValue,
                                              param[3].DoubleValue, param[4].DoubleValue, param[5].DoubleValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Double, ValType.Double, ValType.Double, ValType.Double))
                    {
                        visualObject.scaleVec(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                              param[3].DoubleValue, param[4].DoubleValue, param[5].DoubleValue,
                                              param[6].DoubleValue);
                        return Value.VOID;
                    }
                    else
                        throw new CompilerException(-1, 313, Name, name, Value.PrintTypeList(param));

                case "color":
                    if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        visualObject.color(param[0].IntValue, param[1].IntValue, param[2].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer))
                    {
                        visualObject.color(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer))
                    {
                        visualObject.color(param[0].IntValue, param[1].IntValue, param[2].IntValue,
                                           param[3].IntValue, param[4].IntValue, param[5].IntValue,
                                           param[6].IntValue, param[7].IntValue);
                        return Value.VOID;
                    }
                    else if (Value.TypeCompare(param, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer, ValType.Integer, ValType.Integer,
                                               ValType.Integer, ValType.Integer))
                    {
                        visualObject.color(param[0].IntValue, param[1].IntValue, param[2].IntValue,
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