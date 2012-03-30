using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SGL
{
    public partial class ErrorReportForm : Form
    {
        public ErrorReportForm(Exception e)
        {
            InitializeComponent();
            errorTextBox.Text = e.StackTrace;
        }
    }
}
