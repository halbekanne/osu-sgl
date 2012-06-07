using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SGL;
using SGL.Antlr;
using System.Diagnostics;
using SGL.Elements;

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

                Compiler compiler = new Compiler();
                compiler.SetTimeRecording(true);
                outputBox.Text = compiler.Run(inputBox.Text);

            }
            catch (CompilerException ce)
            {
                /*
                if (ce.ErrorType.Equals("Antlr.Parser"))
                {
                    errorBox.Text = "Error (wrong syntax) on " + ce.Message;
                }
                else
                {
                    errorBox.Text = "Error (" + ce.ErrorType + ") on line " + ce.Line + ": " + ce.Message;
                }*/
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
            /*
            UnitTester tester = new UnitTester();
            tester.RunTests();*/
            try {
                int t = 1;
                int x = 4/(1-t);
            } catch (Exception ex) {
                //ErrorReportForm errorReport = new ErrorReportForm(ex);
                throw;
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
