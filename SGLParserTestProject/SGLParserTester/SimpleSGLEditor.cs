using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SGL;
using System.Threading;
using System.IO;

namespace SGLTest
{
    public partial class SimpleSGLEditor : Form
    {

        delegate void GetThisCallback(SimpleSGLEditor editor, String uri);

        public SimpleSGLEditor()
        {
            InitializeComponent();
            SetSyntaxHighlighting();

            // Start update check thread
            UpdateCheck updateObj = new UpdateCheck(this);
            Thread updateChecker = new Thread(updateObj.DoWork);
            updateChecker.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
            updateChecker.Start();
        }

        private void SetSyntaxHighlighting() {
            syntaxSGL.SyntaxFile = Application.StartupPath + @"\SGL.syn";
            //Console.WriteLine("Path: " + Application.StartupPath + @"\SGL.syn");
            SGLBox.ShowScopeIndicator = true;
            syntaxStoryboard.SyntaxFile = Application.StartupPath + @"\OSB.syn";

            //
            
        }

        private void compileSBButton_Click(object sender, EventArgs e)
        {
            storyboardBox.Document.Text = "";
            errorBox.Text = "";

            // Visual stuff
            compilerPBar.Style = ProgressBarStyle.Marquee;
            statusLabel.Text = "Compiling...";

            try
            {
                //Console.WriteLine("input Text: " + SGLBox.Document.Text);
                SGL.Compiler compiler = new SGL.Compiler();
                compiler.SetTimeRecording(true);
                storyboardBox.Document.Text = compiler.Run(SGLBox.Document.Text);

                statusLabel.Text = "";
                tabControl.SelectedTab = tabSB;

            }
            catch (SGLCompilerException ce)
            {
                statusLabel.Text = "Error occured";

                if (ce.ErrorType.Equals("Antlr.Parser"))
                {
                    errorBox.Text = "Error (wrong syntax) on " + ce.Message;
                }
                else
                {
                    errorBox.Text = "Error (" + ce.ErrorType + ") on line " + ce.Line + ": " + ce.Message;
                }
            }
            catch (UnexpectedException ue)
            {
                statusLabel.Text = "Unexpected error occured";

                errorBox.Text = "An unexpected error occured (Error was reported automatically):\r\n" +
                ue.title + "\r\n" +
                ue.trueStackTrace;
            }
            finally
            {
                // Visual stuff
                compilerPBar.Style = ProgressBarStyle.Continuous;
            }
        }

        public void ShowUpdateAvaliable(SimpleSGLEditor editor, String uri)
        {
            // Initializes the variables to pass to the MessageBox.Show method.
            string message = "A newer version is avaliable. Do you want to download it now?";
            string caption = "Update avaliable";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            


            if (this.InvokeRequired)
            {
                GetThisCallback d = new GetThisCallback(ShowUpdateAvaliable);
                this.Invoke(d, new object[] { editor, uri });
            }
            else
            {
                // Displays the MessageBox.
                result = MessageBox.Show(editor, message, caption, buttons, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    // Open standard browser with the dl page
                    System.Diagnostics.Process.Start(uri);
                }
            }


            
        }

        private void SimpleSGLEditor_Load(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            String input = Microsoft.VisualBasic.Interaction.InputBox("Please describe the error you found in the box below", "Error Report System", "", SystemInformation.PrimaryMonitorSize.Width / 2 - 100, SystemInformation.PrimaryMonitorSize.Height / 2 - 100);

            if (input.Length > 10)
            {
                // Report error
                ErrorReporter errObj = new ErrorReporter(new Exception(input), SGLBox.Document.Text, "undefined");
                Thread errorReporter = new Thread(errObj.DoWork);
                errorReporter.CurrentUICulture = new System.Globalization.CultureInfo("en-US");
                errorReporter.Start();
            }

        }

        private void SGLBox_Click(object sender, EventArgs e)
        {

        }

        private void CopyrightLabel_Click(object sender, EventArgs e)
        {

        }

        private void miNew_Click(object sender, EventArgs e)
        {
            string message = "Are you sure that you want to make a new document? All unsaved changes will get lost.";
            string caption = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Display the MessageBox
            result = MessageBox.Show(this, message, caption, buttons, MessageBoxIcon.Information);

            if (result == DialogResult.Yes)
            {
                // Clear all boxes
                SGLBox.Document.Text = "";
                storyboardBox.Document.Text = "";
                errorBox.Text = "";
                statusLabel.Text = "";
            }
        }

        private void miOpen_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a file.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Storyboard Generation File|*.sgf";
            openFileDialog1.Title = "Select a File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .sgf file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.OpenFile());
                SGLBox.Document.Text = reader.ReadToEnd();
            }
        }

        private void miSaveSgf_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Storyboard Generation File|*.sgf";
            saveFileDialog1.Title = "Save the Storyboard Generation File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.

                file.Write(SGLBox.Document.Text);

                file.Close();
            }
        }

        private void miSaveOsb_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Osu Storyboard File|*.osb";
            saveFileDialog1.Title = "Save the Storyboard File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.StreamWriter file = new System.IO.StreamWriter(saveFileDialog1.OpenFile());
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.

                file.Write(storyboardBox.Document.Text);
                
                file.Close();
            }
        }




    }
}
