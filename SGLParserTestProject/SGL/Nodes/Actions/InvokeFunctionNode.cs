using System;
using System.Collections.Generic;
using SGL.Elements;
using SGL.Library.Classes;
using SGL.Library.Functions;

namespace SGL.Nodes.Actions
{
    internal class InvokeFunctionNode : AbstractNode
    {
        private readonly String funcName;
        private readonly int line;
        private readonly String objectVar;
        private readonly List<AbstractNode> parameters;
        private readonly Scope scope;

        public InvokeFunctionNode(String funcName, List<AbstractNode> parameters, int line)
        {
            // It's checked weather or not the function name itself exists in order to avoid typos at an early state
            if (!LibraryManager.Instance.IsFunctionKnown(funcName) && !GlobalMemory.Instance.IsFunctionKnown(funcName))
            {
                throw new CompilerException(line, 301, funcName);
            }
            this.funcName = funcName;
            this.parameters = parameters != null ? parameters : new List<AbstractNode>();
            this.line = line;
        }

        public InvokeFunctionNode(String objectVar, List<AbstractNode> indexes, String funcName,
                                  List<AbstractNode> parameters, Scope scope, int line)
        {
            this.funcName = funcName;
            this.parameters = parameters != null ? parameters : new List<AbstractNode>();
            this.objectVar = objectVar;
            this.scope = scope;
            this.line = line;
        }

        public override int Line
        {
            get { return line; }
        }

        protected override Value Invoke()
        {
            if (objectVar != null && scope != null)
            {
                var values = new List<Value>();
                foreach (AbstractNode node in parameters)
                {
                    values.Add(node.Evaluate());
                }

                Value resolvedValue = scope.Resolve(objectVar);
                if (resolvedValue == null)
                {
                    throw new CompilerException(line, 211, objectVar);
                }
                if (resolvedValue.Type == ValType.Object)
                {
                    try
                    {
                        AbstractClass objectInstance = resolvedValue.ObjectValue;
                        return objectInstance.InvokeMethod(funcName, values);
                    }
                    catch (CompilerException ce)
                    {
                        if (ce.ErrorCode == 314)
                        {
                            if (GlobalMemory.Instance.IsFunctionKnown(funcName))
                            {
                                Function function = GlobalMemory.Instance.GetFunction(funcName, values);
                                if (function is UserFunction)
                                {
                                    GlobalMemory.Instance.AddCallToStack(new CallItem(funcName, Line));
                                    Value returnValue = ((UserFunction) function).Invoke(resolvedValue, values);
                                    GlobalMemory.Instance.PopLastCall();
                                    return returnValue;
                                }
                                else
                                {
                                    throw;
                                }
                            }
                            else
                            {
                                throw;
                            }
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
                throw new CompilerException(line, 316, resolvedValue.TypeString);
            }
            else
            {
                var values = new List<Value>();
                foreach (AbstractNode node in parameters)
                {
                    values.Add(node.Evaluate());
                }

                Function function;
                if (LibraryManager.Instance.IsFunctionKnown(funcName))
                {
                    function = LibraryManager.Instance.GetFunction(funcName, values);
                    return function.Invoke(values);
                }
                else
                {
                    GlobalMemory.Instance.AddCallToStack(new CallItem(funcName, Line));
                    function = GlobalMemory.Instance.GetFunction(funcName, values);
                    Value returnValue = function.Invoke(values);
                    GlobalMemory.Instance.PopLastCall();
                    return returnValue;
                }
            }
        }
    }
}