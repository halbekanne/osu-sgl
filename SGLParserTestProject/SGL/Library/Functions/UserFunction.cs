using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using SGL.Antlr;
using SGL.Elements;

namespace SGL.Library.Functions
{
    /// <summary>
    /// A method defined by "method [name]() { ... } in the actuall SGL code."
    /// </summary>
    internal class UserFunction : Function
    {
        private readonly CommonTree functionBody;
        private readonly List<String> parameterNames;
        private int definedLine;
        private String name;

        // method xyt(param1, param2) {
        public UserFunction(String name, List<String> parameterNames, CommonTree functionBody, int definedLine)
        {
            this.parameterNames = parameterNames;
            this.functionBody = functionBody;
            this.name = name;
            this.definedLine = definedLine;
        }

        public override Value Invoke(List<Value> parameters)
        {
            if (parameters.Count == parameterNames.Count)
            {
                // create new scope for the method call
                var methodScope = new Scope();
                for (int i = 0; i < parameterNames.Count; i++)
                {
                    methodScope.Define(parameterNames[i]);
                    methodScope.Assign(parameterNames[i], parameters[i]);
                }

                var nodeStream = new CommonTreeNodeStream(functionBody);
                // Create a tree walker to evaluate this method's code block  
                var walker = new SGLTreeWalker(nodeStream, methodScope);

                // Ok, executing the function then
                Value returnValue = walker.main().Evaluate();

                // we shouldn't check the return type
                /*if (!returnValue.GetVarType().Equals(this.returnType))
                {
                    throw new Exception("The method doesn't return the expected return type (" + returnValue.ToString()  + " is not from type " + this.returnType + ")");
                }*/
                return returnValue;
            }
            // TODO: Exception
            throw new Exception();
        }

        public Value Invoke(Value objectVar, List<Value> parameters)
        {
            if (parameters.Count == parameterNames.Count)
            {
                // create new scope for the method call
                var methodScope = new Scope();
                methodScope.Define("this");
                methodScope.Assign("this", objectVar);
                for (int i = 0; i < parameterNames.Count; i++)
                {
                    methodScope.Define(parameterNames[i]);
                    methodScope.Assign(parameterNames[i], parameters[i]);
                }


                var nodeStream = new CommonTreeNodeStream(functionBody);
                // Create a tree walker to evaluate this method's code block  
                var walker = new SGLTreeWalker(nodeStream, methodScope);

                Value returnValue = null;

                // Ok, executing the function then
                returnValue = walker.main().Evaluate();


                // we shouldn't check the return type
                /*if (!returnValue.GetVarType().Equals(this.returnType))
                {
                    throw new Exception("The method doesn't return the expected return type (" + returnValue.ToString()  + " is not from type " + this.returnType + ")");
                }*/
                return returnValue;
            }
            // TODO: Exception
            throw new Exception();
        }
    }
}