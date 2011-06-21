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
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCanel = new System.Windows.Forms.Button();
            this.yTrackBar = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // xTrackBar
            // 
            this.xTrackBar.AutoSize = false;
            this.xTrackBar.Location = new System.Drawing.Point(12, 12);
            this.xTrackBar.Maximum = 320;
            this.xTrackBar.Minimum = -320;
            this.xTrackBar.Name = "xTrackBar";
            this.xTrackBar.Size = new System.Drawing.Size(177, 25);
            this.xTrackBar.TabIndex = 0;
            this.xTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.xTrackBar.Scroll += new System.EventHandler(this.MeasureTrackBar_Scroll);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(195, 43);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(45, 20);
            this.yTextBox.TabIndex = 3;
            this.yTextBox.Text = "0";
            this.yTextBox.TextChanged += new System.EventHandler(this.measureTextBox_TextChanged);
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(195, 12);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(45, 20);
            this.xTextBox.TabIndex = 4;
            this.xTextBox.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "x";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(94, 87);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(79, 23);
            this.buttonOK.TabIndex = 7;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click_1);
            // 
            // buttonCanel
            // 
            this.buttonCanel.Location = new System.Drawing.Point(179, 87);
            this.buttonCanel.Name = "buttonCanel";
            this.buttonCanel.Size = new System.Drawing.Size(79, 23);
            this.buttonCanel.TabIndex = 8;
            this.buttonCanel.Text = "Cancel";
            this.buttonCanel.UseVisualStyleBackColor = true;
            // 
            // yTrackBar
            // 
            this.yTrackBar.AutoSize = false;
            this.yTrackBar.Location = new System.Drawing.Point(12, 43);
            this.yTrackBar.Maximum = 240;
            this.yTrackBar.Minimum = -240;
            this.yTrackBar.Name = "yTrackBar";
            this.yTrackBar.Size = new System.Drawing.Size(177, 25);
            this.yTrackBar.TabIndex = 9;
            this.yTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "y";
            // 
            // ShiftTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 122);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yTrackBar);
            this.Controls.Add(this.buttonCanel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.xTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShiftTimeForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Move Selection...";
            ((System.ComponentModel.ISupportInitialize)(this.xTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar xTrackBar;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCanel;
        private System.Windows.Forms.TrackBar yTrackBar;
        private System.Windows.Forms.Label label2;

    }
}