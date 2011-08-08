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
            Console.WriteLine(exprV.AsInteger().ToString());
            if (exprV == SGLValue.VOID)
            {
                throw new Exception("can't assign VOID to " + name);
            }

            if (type.Equals("int"))
            {
                // Integer hinzufügen
                if (exprV.IsNumber())
                {
                    scope.Assign(name, new SGLValue(exprV.AsInteger()), true);
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
                    scope.Assign(name, new SGLValue(exprV.AsFloat()), true);
                }
                else
                {
                    throw new Exception(exprV.ToString() + " can't be parsed to a float value.");
                }
            }
            if (type.Equals("string"))
            {
                // String hinzufügen
                if (exprV.IsString())
                {
                    scope.Assign(name, new SGLValue(exprV.AsString()), true);
                }
                else
                {
                    throw new Exception(exprV.ToString() + " can't be parsed to a string.");
                }
            }



            return SGLValue.VOID;
        }


    }
}
