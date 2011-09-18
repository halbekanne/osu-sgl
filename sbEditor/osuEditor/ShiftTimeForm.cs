using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace osuEditor
{
    public partial class ShiftTimeForm : Form
    {

        private float BPM;

        public ShiftTimeForm(float BPM)
        {
            this.BPM = BPM;
            InitializeComponent();
        }

        private int ms = 0;

        public int GetMs() {
            return ms;
        }

        private void buttonOK_Click_1(object sender, EventArgs e)
        {
            ms = Convert.ToInt32(msTextBox.Text);
            DialogResult = DialogResult.OK;
        }

        private void MeasureTrackBar_Scroll(object sender, EventArgs e)
        {
            measureTextBox.Text = ((MeasureTrackBar.Value - 20) / 8.0).ToString();
        }

        private void measureTextBox_TextChanged(object sender, EventArgs e)
        {
            float measures = (float)Convert.ToDouble(measureTextBox.Text);
            msTextBox.Text = Convert.ToInt16((60000 * measures * 4) / BPM).ToString();
        }
    }
}
