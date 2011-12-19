#pragma warning disable 168, 219
// Unreachable code detected.
#pragma warning disable 162

using System.Collections.Generic;
using SGL;


using System;
using Antlr.Runtime;
using IList = System.Collections.IList;
using ArrayList = System.Collections.ArrayList;
using Stack = Antlr.Runtime.Collections.StackList;



using Antlr.Runtime.Tree;
namespace SGL.AntlrParser
{
    class SGLCheckerOTF : SGLParser
    {

        private String lastError = "";

        public List<CheckerOTF.Error> errors = new List<CheckerOTF.Error>();



        public SGLCheckerOTF(ITokenStream input) : base(input) {
        }

        public SGLCheckerOTF(ITokenStream input, RecognizerSharedState state) : base(input, state) {
        }

        
        public override void EmitErrorMessage(string msg)
        {
            String[] words = msg.Split(' ');
            int line = -1, character = -1;
            String message = "";

            for (int a = 0; a < words.Length; a++)
            {
                if (a == 1)
                {
                    String[] pos = words[a].Split(':');
                    line = Int32.Parse(pos[0]);
                    character = Int32.Parse(pos[1]);
                }
                else if (a > 1)
                {
                    message += words[a] + " ";
                }
            }

            errors.Add(new CheckerOTF.Error(line, message));
        }
         
        /*
        public override void ReportError(Antlr.Runtime.RecognitionException e)
        {
            errors.Add(new CheckerOTF.Error(e.Line, lastError));
            base.ReportError(e);
        }
         */

    }
}
