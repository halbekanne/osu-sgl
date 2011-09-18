using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace osuEditor
{
    public partial class FindReplaceForm : Form
    {
        public FindReplaceForm()
        {
            InitializeComponent();
        }

        private void FindReplaceForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = Settings.Opacity;
            //MessageBox.Show("Deactivate!");
        }

        private void FindReplaceForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
        }

        private void findNextButton_Click(object sender, EventArgs e)
        {
            String search = findTextField.Text;
            OsuSbEditor owner = (OsuSbEditor)Owner;
            String text = owner.editorDocument.Text;

            // Additional Information
            int startposition = owner.editorControl.Caret.Position;

            // Suche search in text
            int index = text.IndexOf(search);
            //MessageBox.Show("" + index);

            // Markieren des Textes
            owner.editorControl.Selection.SelStart = index;
            owner.editorControl.Selection.SelEnd = index + search.Length;
            owner.Activate();
            this.Activate();
            //owner.editorControl.Selection.MakeSelection();


        }



    }
}
