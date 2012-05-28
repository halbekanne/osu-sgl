using System;
using System.Collections.Generic;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace SGLOld.Nodes.Methods
{
    class UserMethod : IMethod
    {
        private String name;
        private List<String> parameterNames;
        private CommonTreeNodeStream block;
        private Scope scope;

        public UserMethod(String name, List<String> parameterNames, CommonTreeNodeStream block)
        {
            this.name = name;
            this.parameterNames = parameterNames;
            this.block = block;
            this.scope = new Scope();
        }

        public UserMethod(UserMethod original)
        {
            // Used for recursively calling methods  
            this.name = original.name;
            this.parameterNames = original.parameterNames;
            this.block = original.block;
            this.scope = original.scope.Copy();
        }

        public Value Invoke(List<Value> parameters)
        {
            if (parameters.Count != parameterNames.Count)
            {
                throw new CompilerException(-1, 302, new String[] {name, parameters.Count.ToString()});
            }








        }

    }
}
