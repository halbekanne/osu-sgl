using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SGL;
using SGL.AntlrParser;
using SGL.SGLUnit;
using System.Diagnostics;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void compileBtn_Click(object sender, EventArgs e)
        {
            outputBox.Text = "";
            errorBox.Text = "";

            try
            {

                SGL.Compiler compiler = new SGL.Compiler();
                compiler.SetTimeRecording(true);
                outputBox.Text = compiler.Run(inputBox.Text);

            }
            catch (SGLCompilerException ce)
            {
                if (ce.ErrorType.Equals("Antlr.Parser"))
                {
                    errorBox.Text = "Error (wrong syntax) on " + ce.Message;
                }
                else
                {
                    errorBox.Text = "Error (" + ce.ErrorType + ") on line " + ce.Line + ": " + ce.Message;
                }
            }
            catch (Exception ex)
            {
                outputBox.Text = "Es ist ein Fehler aufgetreten.";
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            UnitTester tester = new UnitTester();
            tester.RunTests();
        }


    }
}
