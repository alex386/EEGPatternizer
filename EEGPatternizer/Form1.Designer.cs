//using EEGPanel;

namespace EEGPatternizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.Info = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.FilePathEdit = new System.Windows.Forms.TextBox();
            this.Browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Tdelay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pLicz = new System.Windows.Forms.Label();
            this.checkRAW = new System.Windows.Forms.CheckBox();
            this.checkFFT = new System.Windows.Forms.CheckBox();
            this.checkDWT = new System.Windows.Forms.CheckBox();
            this.checkPSRD = new System.Windows.Forms.CheckBox();
            this.checkPSRDC = new System.Windows.Forms.CheckBox();
            this.checkD4 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.gPanel8 = new EEGPatternizer.GPanel();
            this.gPanel7 = new EEGPatternizer.GPanel();
            this.gPanel6 = new EEGPatternizer.GPanel();
            this.gPanel5 = new EEGPatternizer.GPanel();
            this.gPanel4 = new EEGPatternizer.GPanel();
            this.gPanel3 = new EEGPatternizer.GPanel();
            this.gPanel2 = new EEGPatternizer.GPanel();
            this.gPanel1 = new EEGPatternizer.GPanel();
            this.checkPSRT = new System.Windows.Forms.CheckBox();
            this.checkPSRTC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Raw signal";
            // 
            // Info
            // 
            this.Info.AutoSize = true;
            this.Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Info.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.Info.Location = new System.Drawing.Point(328, 454);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(80, 20);
            this.Info.TabIndex = 4;
            this.Info.Text = "Patterns";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(545, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "FFT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(552, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "PSRT";
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.SelectedPath = "D:\\Moje publikacje\\EEG_Project\\Soft\\EEGControl2\\EEGControl2\\bin\\x64\\Release\\RawDa" +
    "ta";
            // 
            // FilePathEdit
            // 
            this.FilePathEdit.Location = new System.Drawing.Point(12, 174);
            this.FilePathEdit.Name = "FilePathEdit";
            this.FilePathEdit.Size = new System.Drawing.Size(800, 22);
            this.FilePathEdit.TabIndex = 31;
            // 
            // Browse
            // 
            this.Browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Browse.Location = new System.Drawing.Point(682, 28);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(128, 128);
            this.Browse.TabIndex = 32;
            this.Browse.Text = "Browse";
            this.Browse.UseVisualStyleBackColor = true;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "PSRDC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 34;
            this.label4.Text = "Haar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "PSRD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(688, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "PSRTC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.label8.Location = new System.Drawing.Point(326, 412);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Delay value";
            // 
            // Tdelay
            // 
            this.Tdelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tdelay.Location = new System.Drawing.Point(446, 411);
            this.Tdelay.Name = "Tdelay";
            this.Tdelay.Size = new System.Drawing.Size(100, 26);
            this.Tdelay.TabIndex = 38;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(566, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 107);
            this.button1.TabIndex = 39;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pLicz
            // 
            this.pLicz.AutoSize = true;
            this.pLicz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pLicz.ForeColor = System.Drawing.Color.Blue;
            this.pLicz.Location = new System.Drawing.Point(414, 454);
            this.pLicz.Name = "pLicz";
            this.pLicz.Size = new System.Drawing.Size(58, 20);
            this.pLicz.TabIndex = 40;
            this.pLicz.Text = "Count";
            // 
            // checkRAW
            // 
            this.checkRAW.AutoSize = true;
            this.checkRAW.Checked = true;
            this.checkRAW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkRAW.Location = new System.Drawing.Point(92, 9);
            this.checkRAW.Name = "checkRAW";
            this.checkRAW.Size = new System.Drawing.Size(18, 17);
            this.checkRAW.TabIndex = 41;
            this.checkRAW.UseVisualStyleBackColor = true;
            // 
            // checkFFT
            // 
            this.checkFFT.AutoSize = true;
            this.checkFFT.Checked = true;
            this.checkFFT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFFT.Location = new System.Drawing.Point(579, 8);
            this.checkFFT.Name = "checkFFT";
            this.checkFFT.Size = new System.Drawing.Size(18, 17);
            this.checkFFT.TabIndex = 42;
            this.checkFFT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.checkFFT.UseVisualStyleBackColor = true;
            // 
            // checkDWT
            // 
            this.checkDWT.AutoSize = true;
            this.checkDWT.Checked = true;
            this.checkDWT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkDWT.Location = new System.Drawing.Point(60, 205);
            this.checkDWT.Name = "checkDWT";
            this.checkDWT.Size = new System.Drawing.Size(18, 17);
            this.checkDWT.TabIndex = 43;
            this.checkDWT.UseVisualStyleBackColor = true;
            // 
            // checkPSRD
            // 
            this.checkPSRD.AutoSize = true;
            this.checkPSRD.Checked = true;
            this.checkPSRD.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPSRD.Location = new System.Drawing.Point(331, 205);
            this.checkPSRD.Name = "checkPSRD";
            this.checkPSRD.Size = new System.Drawing.Size(18, 17);
            this.checkPSRD.TabIndex = 44;
            this.checkPSRD.UseVisualStyleBackColor = true;
            // 
            // checkPSRDC
            // 
            this.checkPSRDC.AutoSize = true;
            this.checkPSRDC.Checked = true;
            this.checkPSRDC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPSRDC.Location = new System.Drawing.Point(478, 205);
            this.checkPSRDC.Name = "checkPSRDC";
            this.checkPSRDC.Size = new System.Drawing.Size(18, 17);
            this.checkPSRDC.TabIndex = 45;
            this.checkPSRDC.UseVisualStyleBackColor = true;
            // 
            // checkD4
            // 
            this.checkD4.AutoSize = true;
            this.checkD4.Checked = true;
            this.checkD4.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkD4.Location = new System.Drawing.Point(123, 363);
            this.checkD4.Name = "checkD4";
            this.checkD4.Size = new System.Drawing.Size(18, 17);
            this.checkD4.TabIndex = 47;
            this.checkD4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 17);
            this.label9.TabIndex = 46;
            this.label9.Text = "Daubechies D4";
            // 
            // gPanel8
            // 
            this.gPanel8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel8.Location = new System.Drawing.Point(18, 382);
            this.gPanel8.Name = "gPanel8";
            this.gPanel8.Size = new System.Drawing.Size(256, 128);
            this.gPanel8.TabIndex = 21;
            this.gPanel8.TabStop = true;
            this.gPanel8.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel8_Paint);
            // 
            // gPanel7
            // 
            this.gPanel7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel7.Location = new System.Drawing.Point(414, 225);
            this.gPanel7.Name = "gPanel7";
            this.gPanel7.Size = new System.Drawing.Size(128, 128);
            this.gPanel7.TabIndex = 22;
            this.gPanel7.TabStop = true;
            this.gPanel7.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel7_Paint);
            // 
            // gPanel6
            // 
            this.gPanel6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel6.Location = new System.Drawing.Point(280, 225);
            this.gPanel6.Name = "gPanel6";
            this.gPanel6.Size = new System.Drawing.Size(128, 128);
            this.gPanel6.TabIndex = 21;
            this.gPanel6.TabStop = true;
            this.gPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel6_Paint);
            // 
            // gPanel5
            // 
            this.gPanel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel5.Location = new System.Drawing.Point(18, 225);
            this.gPanel5.Name = "gPanel5";
            this.gPanel5.Size = new System.Drawing.Size(256, 128);
            this.gPanel5.TabIndex = 20;
            this.gPanel5.TabStop = true;
            this.gPanel5.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel5_Paint);
            // 
            // gPanel4
            // 
            this.gPanel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel4.Location = new System.Drawing.Point(548, 225);
            this.gPanel4.Name = "gPanel4";
            this.gPanel4.Size = new System.Drawing.Size(128, 128);
            this.gPanel4.TabIndex = 21;
            this.gPanel4.TabStop = true;
            this.gPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel4_Paint);
            // 
            // gPanel3
            // 
            this.gPanel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel3.Location = new System.Drawing.Point(682, 225);
            this.gPanel3.Name = "gPanel3";
            this.gPanel3.Size = new System.Drawing.Size(128, 128);
            this.gPanel3.TabIndex = 20;
            this.gPanel3.TabStop = true;
            this.gPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel3_Paint);
            // 
            // gPanel2
            // 
            this.gPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel2.Location = new System.Drawing.Point(548, 28);
            this.gPanel2.Name = "gPanel2";
            this.gPanel2.Size = new System.Drawing.Size(128, 128);
            this.gPanel2.TabIndex = 19;
            this.gPanel2.TabStop = true;
            this.gPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel2_Paint);
            // 
            // gPanel1
            // 
            this.gPanel1.BackColor = System.Drawing.SystemColors.ControlText;
            this.gPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gPanel1.Location = new System.Drawing.Point(12, 28);
            this.gPanel1.Name = "gPanel1";
            this.gPanel1.Size = new System.Drawing.Size(512, 128);
            this.gPanel1.TabIndex = 18;
            this.gPanel1.TabStop = true;
            this.gPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.gPanel1_Paint);
            // 
            // checkPSRT
            // 
            this.checkPSRT.AutoSize = true;
            this.checkPSRT.Checked = true;
            this.checkPSRT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPSRT.Location = new System.Drawing.Point(606, 206);
            this.checkPSRT.Name = "checkPSRT";
            this.checkPSRT.Size = new System.Drawing.Size(18, 17);
            this.checkPSRT.TabIndex = 48;
            this.checkPSRT.UseVisualStyleBackColor = true;
            // 
            // checkPSRTC
            // 
            this.checkPSRTC.AutoSize = true;
            this.checkPSRTC.Checked = true;
            this.checkPSRTC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPSRTC.Location = new System.Drawing.Point(751, 206);
            this.checkPSRTC.Name = "checkPSRTC";
            this.checkPSRTC.Size = new System.Drawing.Size(18, 17);
            this.checkPSRTC.TabIndex = 49;
            this.checkPSRTC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 525);
            this.Controls.Add(this.checkPSRTC);
            this.Controls.Add(this.checkPSRT);
            this.Controls.Add(this.checkD4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gPanel8);
            this.Controls.Add(this.checkPSRDC);
            this.Controls.Add(this.checkPSRD);
            this.Controls.Add(this.checkDWT);
            this.Controls.Add(this.checkFFT);
            this.Controls.Add(this.checkRAW);
            this.Controls.Add(this.pLicz);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tdelay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gPanel7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gPanel6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gPanel5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gPanel4);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.FilePathEdit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gPanel3);
            this.Controls.Add(this.gPanel2);
            this.Controls.Add(this.gPanel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Info);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "EEG pattern generator ver 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        //private EEGPlot eegPlot1;
        private System.Windows.Forms.Label label1;
       // private EEGPlot eegPlot2;
        private System.Windows.Forms.Label Info;
        //private EEGPlot eegIMG;
        private System.Windows.Forms.Label label3;

         private GPanel gPanel1;
         private GPanel gPanel2;
         private GPanel gPanel3;

       // private EEGPatternizer.GPanel gPanel1;
      //  private GPanel gPanel2;
      //  private GPanel gPanel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox FilePathEdit;
        private System.Windows.Forms.Button Browse;
        private GPanel gPanel4;
        private System.Windows.Forms.Label label2;
        private GPanel gPanel5;
        private System.Windows.Forms.Label label4;
        private GPanel gPanel6;
        private System.Windows.Forms.Label label6;
        private GPanel gPanel7;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Tdelay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label pLicz;
        private System.Windows.Forms.CheckBox checkRAW;
        private System.Windows.Forms.CheckBox checkFFT;
        private System.Windows.Forms.CheckBox checkDWT;
        private System.Windows.Forms.CheckBox checkPSRD;
        private System.Windows.Forms.CheckBox checkPSRDC;
        private GPanel gPanel8;
        private System.Windows.Forms.CheckBox checkD4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkPSRT;
        private System.Windows.Forms.CheckBox checkPSRTC;
        //private EEGPlot eegPlot1;
    }
}

