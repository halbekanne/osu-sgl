using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace osuEditor
{
    public partial class MovePlaceForm : Form
    {
        private int x = 0;
        private int y = 0;

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public MovePlaceForm()
        {
            InitializeComponent();
        }

        private void xTrackBar_Scroll(object sender, EventArgs e)
        {
            xTextBox.Text = xTrackBar.Value.ToString();
        }

        private void yTrackBar_Scroll(object sender, EventArgs e)
        {
            yTextBox.Text = yTrackBar.Value.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            x = Convert.ToInt32(xTextBox.Text);
            y = Convert.ToInt32(yTextBox.Text);
            DialogResult = DialogResult.OK;
        }


    }
}
