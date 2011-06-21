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
            this.xTrackBar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCanel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // MeasureTrackBar
            // 
            this.xTrackBar.AutoSize = false;
            this.xTrackBar.Location = new System.Drawing.Point(12, 12);
            this.xTrackBar.Maximum = 40;
            this.xTrackBar.Name = "MeasureTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(217, 25);
            this.xTrackBar.TabIndex = 0;
            this.xTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.xTrackBar.Value = 20;
            this.xTrackBar.Scroll += new System.EventHandler(this.MeasureTrackBar_Scroll);
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
            this.yTextBox.Location = new System.Drawing.Point(97, 51);
            this.yTextBox.Name = "measureTextBox";
            this.yTextBox.Size = new System.Drawing.Size(80, 20);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.Text = "0";
            this.yTextBox.TextChanged += new System.EventHandler(this.measureTextBox_TextChanged);
            // 
            // msTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(98, 78);
            this.xTextBox.Name = "msTextBox";
            this.xTextBox.Size = new System.Drawing.Size(79, 20);
            this.xTextBox.TabIndex = 4;
            this.xTextBox.Text = "0";
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
            // ShiftTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 148);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftTimeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Shift Selection...";
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar MeasureTrackBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox measureTextBox;
        private System.Windows.Forms.TextBox msTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCanel;

    }
}