namespace Notepad_Light.Forms
{
    partial class FrmPasteUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPasteUI));
            label1 = new Label();
            cboClipFormats = new ComboBox();
            BtnOK = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(129, 20);
            label1.TabIndex = 0;
            label1.Text = "Clipboard Format:";
            // 
            // cboClipFormats
            // 
            cboClipFormats.FormattingEnabled = true;
            cboClipFormats.Location = new Point(149, 9);
            cboClipFormats.Margin = new Padding(3, 4, 3, 4);
            cboClipFormats.Name = "cboClipFormats";
            cboClipFormats.Size = new Size(291, 28);
            cboClipFormats.TabIndex = 1;
            cboClipFormats.KeyDown += cboClipFormats_KeyDown;
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(270, 47);
            BtnOK.Margin = new Padding(3, 4, 3, 4);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(67, 31);
            BtnOK.TabIndex = 2;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(344, 47);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(86, 31);
            BtnCancel.TabIndex = 3;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmPasteUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 88);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOK);
            Controls.Add(cboClipFormats);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmPasteUI";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Paste Options";
            KeyDown += FrmPasteUI_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboClipFormats;
        private Button BtnOK;
        private Button BtnCancel;
    }
}