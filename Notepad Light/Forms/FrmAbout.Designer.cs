namespace Notepad_Light.Forms
{
    partial class FrmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbout));
            BtnOK = new Button();
            groupBox1 = new GroupBox();
            TxbSysInfo = new TextBox();
            label1 = new Label();
            lblVersion = new Label();
            BtnOpenErrorLog = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(457, 309);
            BtnOK.Margin = new Padding(3, 4, 3, 4);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(75, 31);
            BtnOK.TabIndex = 1;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxbSysInfo);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblVersion);
            groupBox1.Location = new Point(14, 4);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(519, 297);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // TxbSysInfo
            // 
            TxbSysInfo.Location = new Point(7, 63);
            TxbSysInfo.Margin = new Padding(3, 4, 3, 4);
            TxbSysInfo.Multiline = true;
            TxbSysInfo.Name = "TxbSysInfo";
            TxbSysInfo.ScrollBars = ScrollBars.Both;
            TxbSysInfo.Size = new Size(504, 225);
            TxbSysInfo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 25);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 2;
            label1.Text = "Notepad Light";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVersion.Location = new Point(283, 25);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(69, 20);
            lblVersion.TabIndex = 0;
            lblVersion.Text = "Version: ";
            // 
            // BtnOpenErrorLog
            // 
            BtnOpenErrorLog.Location = new Point(14, 309);
            BtnOpenErrorLog.Margin = new Padding(3, 4, 3, 4);
            BtnOpenErrorLog.Name = "BtnOpenErrorLog";
            BtnOpenErrorLog.Size = new Size(123, 31);
            BtnOpenErrorLog.TabIndex = 2;
            BtnOpenErrorLog.Text = "Open Error Log";
            BtnOpenErrorLog.UseVisualStyleBackColor = true;
            BtnOpenErrorLog.Click += BtnOpenErrorLog_Click;
            // 
            // FrmAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(546, 356);
            Controls.Add(BtnOpenErrorLog);
            Controls.Add(BtnOK);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(2, 1, 2, 1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "About";
            KeyDown += FrmAbout_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button BtnOK;
        private GroupBox groupBox1;
        private Label label1;
        private Label lblVersion;
        private Button BtnOpenErrorLog;
        private TextBox TxbSysInfo;
    }
}