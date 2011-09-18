using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace osuEditor
{
    public partial class OsuSbEditor : Form
    {
        private readonly FileController _controller;
        private readonly String _title;
        private float BPM = 100;
        private ShiftTimeForm shiftTime = null;
        

        public OsuSbEditor()
        {
            InitializeComponent();
            _controller = new FileController();
            _title = this.Text;

            // Avoid Confirmation Message
            _controller.Saved = true;
            NewFile();
        }

        private void SaveTo(String filePath)
        {
            String text = editorDocument.Text;
            /*
            defaultTab.Text = filePath;
            _controller.FilePath = filePath;
            _controller.SaveFile(text);
            _controller.Saved = true;
            RefreshTitle();
             * */
        }

        private void NewFile()
        {
            if (!_controller.Saved)
            {
                if (MessageBox.Show("You're file has not been saved, yet. Do you really want to create a new File?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            /*
            _controller.FilePath = "";
            _controller.Saved = true;
            defaultTab.Text = "new file";
            editorDocument.Text = "";
            RefreshTitle();
             * */
        }

        private void RefreshTitle()
        {
            if ( _controller.FilePath != "" )
            {
                if (_controller.Saved)
                    this.Text = _title + " - \"" + _controller.FilePath + "\" (saved)";
                else
                    this.Text = _title + " - \"" + _controller.FilePath + "\"";
            }
            else
            {
                this.Text = _title + "";
            }
        }

        private static String FileChooser(bool save)
        {
            try
            {
                if (save)
                {
                    var fileDialog = new SaveFileDialog();
                    fileDialog.ShowDialog();

                    return fileDialog.FileName;
                }
                else
                {
                    var fileDialog = new OpenFileDialog();
                    fileDialog.ShowDialog();

                    return fileDialog.FileName;
                }
            }
            catch (ArgumentException argumentException)
            {
                return "";
            }

        }

        private void CheckSave()
        {

        }

        // Moves a Selection ín Time
        private String MoveSelectionTime(String text)
        {
            


            return "";
        }





        // Form Events

        private void OpenToolStripMenuItemClick(object sender, EventArgs e)
        {

            String filepath = FileChooser(false);

            if (filepath != "")
            {
                /*
                _controller.FilePath = filepath;
                defaultTab.Text = filepath;

                String[] fileContent = _controller.ReadFile();
                for (int i = 0; i < fileContent.Length; i++)
                {
                    editorDocument.Insert(fileContent[i], i);
                }

                _controller.Saved = true;
                RefreshTitle();
                 */
            }

        }

        private void SaveToolStripMenuItemClick(object sender, EventArgs e)
        {
            if ( _controller.FilePath == "" )
            {
                String filepath = FileChooser(true);
                if (filepath != "")
                    SaveTo(filepath);
            }
            else
            {
                SaveTo(_controller.FilePath);
            }
            
            RefreshTitle();
        }

        private void SaveAsToolStripMenuItemClick(object sender, EventArgs e)
        {
            String filepath = FileChooser(true);
            if (filepath != "")
                SaveTo(filepath);

            RefreshTitle();
        }

        private void ExitToolStripMenuItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void NewToolStripMenuItemClick(object sender, EventArgs e)
        {
            NewFile();
        }

        private void OsuSbEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_controller.Saved)
            {
                if (MessageBox.Show("You're file has not been saved, yet. Do you really want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void UndoToolStripMenuItemClick(object sender, EventArgs e)
        {
            editorControl.Undo();
        }

        private void RedoToolStripMenuItemClick(object sender, EventArgs e)
        {
            editorControl.Redo();
        }

        private void EditorDocumentModifiedChanged(object sender, EventArgs e)
        {
            _controller.Saved = false;
            RefreshTitle();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editorControl_Click(object sender, EventArgs e)
        {

        }

        private void moveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Move selected Lines in Time
            //MessageBox.Show(editorControl.Selection.Text);
            if (this.shiftTime == null)
            {
                shiftTime = new ShiftTimeForm(BPM);
            }
            if (!shiftTime.Visible)
            {
                shiftTime.Show(this);
            }
        }

        private void moveLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MovePlaceForm chooseMS = new MovePlaceForm();
            if (chooseMS.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(chooseMS.GetX().ToString() + "," + chooseMS.GetY().ToString());

                // User chose the amount of ms
                int x = chooseMS.GetX();
                int y = chooseMS.GetY();

                // Get selected Lines


            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form findReplace = new FindReplaceForm();
            findReplace.Show(this);
            //findReplace.TopLevel = true;
        }

        private void defaultTab_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


    }
}
