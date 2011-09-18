using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.Node
{
    class DeclareVariableNode : SGLNode
    {
        private String type;
        private String name;
        private SGLNode expression;
        private Scope scope;

        public DeclareVariableNode(String type, String name, SGLNode expression, Scope scope)
        {
            this.type = type;
            this.name = name;
            this.expression = expression;
            this.scope = scope;
        }

        public SGLValue Evaluate() {


            SGLValue exprV = expression.Evaluate();

            if (type.Equals("int"))
            {
                // Integer hinzufügen
                if (exprV.IsInteger())
                {
                    scope.Assign(name, new SGLValue(exprV.AsInteger()), true, type);
                }
                else if (exprV.IsFloat())
                {
                    // Convert float expression to int
                    scope.Assign(name, new SGLValue((int)Math.Floor(exprV.AsFloat())), true, type);
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(0), true, type);
                }
                else
                {
                    throw new SGLCompilerException(expression.GetLine(), "type mismatch", "cannot convert from " + exprV.GetVarType() + " to int");
                }
            }
            else if (type.Equals("float"))
            {
                // Float hinzufügen
                if (exprV.IsNumber())
                {
                    scope.Assign(name, new SGLValue(exprV.AsFloat()), true, type);
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(0.0), true, type);
                }
                else
                {
                    throw new SGLCompilerException(expression.GetLine(), "type mismatch", "cannot convert from " + exprV.GetVarType() + " to float");
                
                }
            }
            else if (type.Equals("boolean"))
            {
                // Boolean hinzufügen
                if (exprV.IsBoolean())
                {
                    scope.Assign(name, new SGLValue(exprV.AsBoolean()), true, type);
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(false), true, type);
                }
                else
                {
                    throw new SGLCompilerException(expression.GetLine(), "type mismatch", "cannot convert from " + exprV.GetVarType() + " to boolean");
                
                }
            }
            else if (type.Equals("string"))
            {
                // String hinzufügen
                if (exprV.IsString())
                {
                    scope.Assign(name, new SGLValue(exprV.AsString()), true, type);
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue(""), true, type);
                }
                else
                {
                    throw new SGLCompilerException(expression.GetLine(), "type mismatch", "cannot convert from " + exprV.GetVarType() + " to string");
                
                }
            }
            else if (type.Equals("Object"))
            {
                // String hinzufügen
                if (exprV.IsObject())
                {
                    scope.Assign(name, new SGLValue(exprV.AsObject()), true, type);
                }
                else if (exprV == SGLValue.NULL)
                {
                    scope.Assign(name, new SGLValue("undefined"), true, type);
                }
                else
                {
                    throw new SGLCompilerException(expression.GetLine(), "type mismatch", "cannot convert from " + exprV.GetVarType() + " to Object");
                
                }
            }



            return SGLValue.VOID;
        }

        public int GetLine()
        {
            return expression.GetLine();
        }

    }
}
