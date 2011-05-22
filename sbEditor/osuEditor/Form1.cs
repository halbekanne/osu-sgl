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

            defaultTab.Text = filePath;
            _controller.FilePath = filePath;
            _controller.SaveFile(text);
            _controller.Saved = true;
            RefreshTitle();
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

            _controller.FilePath = "";
            _controller.Saved = true;
            defaultTab.Text = "new file";
            editorDocument.Text = "";
            RefreshTitle();
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


        // Form Events

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String filepath = FileChooser(false);

            if (filepath != "")
            {
                _controller.FilePath = filepath;
                defaultTab.Text = filepath;

                String[] fileContent = _controller.ReadFile();
                for (int i = 0; i < fileContent.Length; i++)
                {
                    editorDocument.Insert(fileContent[i], i);
                }

                _controller.Saved = true;
                RefreshTitle();
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String filepath = FileChooser(true);
            if (filepath != "")
                SaveTo(filepath);

            RefreshTitle();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void osuSbEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_controller.Saved)
            {
                if (MessageBox.Show("You're file has not been saved, yet. Do you really want to exit?", "Confirm Exit", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorControl.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editorControl.Redo();
        }

        private void editorDocument_ModifiedChanged(object sender, EventArgs e)
        {
            _controller.Saved = false;
            RefreshTitle();
        }

    }
}
