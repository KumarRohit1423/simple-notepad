﻿namespace Notepad_Light.Forms
{
    partial class FrmEditTimer
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
            label1 = new Label();
            lblOriginalTime = new Label();
            label3 = new Label();
            label4 = new Label();
            mskTxtBxNewTime = new MaskedTextBox();
            BtnOk = new Button();
            BtnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(25, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 20);
            label1.TabIndex = 0;
            label1.Text = "Adjust Time Format = \"HR:MIN\"";
            // 
            // lblOriginalTime
            // 
            lblOriginalTime.AutoSize = true;
            lblOriginalTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOriginalTime.Location = new Point(158, 56);
            lblOriginalTime.Name = "lblOriginalTime";
            lblOriginalTime.Size = new Size(71, 20);
            lblOriginalTime.TabIndex = 1;
            lblOriginalTime.Text = "00:00:00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(37, 56);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 2;
            label3.Text = "Original Time: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(37, 84);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "New Time:";
            // 
            // mskTxtBxNewTime
            // 
            mskTxtBxNewTime.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            mskTxtBxNewTime.Location = new Point(158, 80);
            mskTxtBxNewTime.Margin = new Padding(3, 4, 3, 4);
            mskTxtBxNewTime.Mask = "90:00";
            mskTxtBxNewTime.Name = "mskTxtBxNewTime";
            mskTxtBxNewTime.Size = new Size(55, 24);
            mskTxtBxNewTime.TabIndex = 4;
            mskTxtBxNewTime.Text = "0000";
            mskTxtBxNewTime.KeyUp += mskTxtBxNewTime_KeyUp;
            // 
            // BtnOk
            // 
            BtnOk.Location = new Point(72, 131);
            BtnOk.Margin = new Padding(3, 4, 3, 4);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(55, 31);
            BtnOk.TabIndex = 5;
            BtnOk.Text = "OK";
            BtnOk.UseVisualStyleBackColor = true;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(134, 131);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(69, 31);
            BtnCancel.TabIndex = 6;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmEditTimer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(275, 177);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOk);
            Controls.Add(mskTxtBxNewTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblOriginalTime);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEditTimer";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Timer";
            KeyDown += FrmEditTimer_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblOriginalTime;
        private Label label3;
        private Label label4;
        private MaskedTextBox mskTxtBxNewTime;
        private Button BtnOk;
        private Button BtnCancel;
    }
}