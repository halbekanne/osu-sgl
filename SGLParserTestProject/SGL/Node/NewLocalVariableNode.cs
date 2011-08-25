using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class NewLocalVariableNode : SGLNode
    {
        private String type;
        private String name;
        private SGLNode expression;
        private Scope scope; 

        public NewLocalVariableNode(String type, String name, SGLNode expression, Scope scope)
        {
            this.type = type;
            this.name = name;
            this.expression = expression;
            this.scope = scope;
        }

        public SGLValue Evaluate() {

            SGLValue exprV = expression.Evaluate();
            if (exprV == SGLValue.VOID)
            {
                throw new Exception("can't assign VOID to " + name);
            }

            if (type.Equals("int"))
            {
                // Integer hinzufügen
                if (exprV.IsInteger())
                {
                    scope.Assign(name, new SGLValue(exprV.AsInteger()), true, type);
                    Console.WriteLine("New integer variable: " + name + " = " + exprV.AsInteger().ToString());
                }
                else if (exprV.IsFloat())
                {
                    // Convert float expression to int
                    scope.Assign(name, new SGLValue((int)Math.Floor(exprV.AsFloat())), true, type);
                    Console.WriteLine("New integer variable + convertion: " + name + " = " + (int)Math.Floor(exprV.AsFloat()));
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(0), true, type);
                    Console.WriteLine("New integer variable: " + name + " = " + 0);
                }
                else
                {
                    throw new Exception(exprV.ToString() + " can't be parsed to an integer value.");
                }
            }
            else if (type.Equals("float"))
            {
                // Float hinzufügen
                if (exprV.IsNumber())
                {
                    scope.Assign(name, new SGLValue(exprV.AsFloat()), true, type);
                    Console.WriteLine("New float variable: " + name + " = " + exprV.AsFloat().ToString());
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(0.0), true, type);
                    Console.WriteLine("New float variable: " + name + " = " + 0.0);
                }
                else
                {
                    throw new Exception(exprV.ToString() + " can't be parsed to a float value.");
                }
            }
            else if (type.Equals("boolean"))
            {
                // Boolean hinzufügen
                if (exprV.IsBoolean())
                {
                    scope.Assign(name, new SGLValue(exprV.AsBoolean()), true, type);
                    Console.WriteLine("New boolean variable: " + name + " = " + exprV.AsBoolean().ToString());
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(false), true, type);
                    Console.WriteLine("New boolean variable: " + name + " = " + false);
                }
                else
                {
                    throw new Exception(exprV.ToString() + " can't be parsed to a boolean value.");
                }
            }
            else if (type.Equals("string"))
            {
                // String hinzufügen
                if (exprV.IsString())
                {
                    scope.Assign(name, new SGLValue(exprV.AsString()), true, type);
                    Console.WriteLine("New string variable: " + name + " = " + exprV.AsString());
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue("\"\""), true, type);
                    Console.WriteLine("New string variable: " + name + " = " + 0);
                }
                else
                {
                    throw new Exception(exprV.ToString() + " can't be parsed to a string.");
                }
            }
            else if (type.Equals("Object"))
            {
                // String hinzufügen
                if (exprV.IsObject())
                {
                    scope.Assign(name, new SGLValue(exprV.AsObject()), true, type);
                    Console.WriteLine("New Object variable: " + name + " = ...");
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue("\"\""), true, type);
                    Console.WriteLine("New Object variable: " + name + " = " + 0);
                }
                else
                {
                    throw new Exception("expression can't be parsed to an object.");
                }
            }



            return SGLValue.VOID;
        }


    }
}
