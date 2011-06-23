namespace osuEditor
{
    partial class ShiftTimeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MeasureTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.measureTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCanel = new System.Windows.Forms.Button();
            this.msTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MeasureTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MeasureTrackBar
            // 
            this.MeasureTrackBar.AutoSize = false;
            this.MeasureTrackBar.Location = new System.Drawing.Point(12, 12);
            this.MeasureTrackBar.Maximum = 40;
            this.MeasureTrackBar.Name = "MeasureTrackBar";
            this.MeasureTrackBar.Size = new System.Drawing.Size(217, 25);
            this.MeasureTrackBar.TabIndex = 0;
            this.MeasureTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.MeasureTrackBar.Value = 20;
            this.MeasureTrackBar.Scroll += new System.EventHandler(this.MeasureTrackBar_Scroll);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(35, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Measures:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(35, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // measureTextBox
            // 
            this.measureTextBox.Location = new System.Drawing.Point(97, 51);
            this.measureTextBox.Name = "measureTextBox";
            this.measureTextBox.Size = new System.Drawing.Size(79, 20);
            this.measureTextBox.TabIndex = 4;
            this.measureTextBox.Text = "0";
            this.measureTextBox.TextChanged += new System.EventHandler(this.measureTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ms";
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(65, 113);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(79, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // buttonCanel
            // 
            this.buttonCanel.Location = new System.Drawing.Point(150, 113);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(79, 23);
            this.buttonCanel.TabIndex = 8;
            this.buttonCanel.Text = "Cancel";
            this.buttonCanel.UseVisualStyleBackColor = true;
            // 
            // msTextBox
            // 
            this.msTextBox.Location = new System.Drawing.Point(97, 78);
            this.msTextBox.Name = "msTextBox";
            this.msTextBox.Size = new System.Drawing.Size(79, 20);
            this.msTextBox.TabIndex = 9;
            this.msTextBox.Text = "0";
            // 
            // ShiftTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 148);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.measureTextBox);
            this.Controls.Add(this.msTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MeasureTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftTimeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shift Selection...";
            ((System.ComponentModel.ISupportInitialize)(this.MeasureTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar MeasureTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox measureTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCanel;
        private System.Windows.Forms.TextBox msTextBox;

    }
}