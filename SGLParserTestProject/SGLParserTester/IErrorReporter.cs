using System;
using System.Collections.Generic;
using System.Text;

namespace SGLOld
{
    public interface IErrorReporter
    {
        void ReportError(String error);
    }

    public class StdErrReporter : IErrorReporter {
        public void ReportError(String error) {
            System.Windows.Forms.MessageBox.Show(error);
            throw new ParseException();
        }
    }

    public class ParseException : Exception
    {

    }
}
