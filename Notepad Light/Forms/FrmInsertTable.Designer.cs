namespace Notepad_Light.Forms
{
    partial class FrmInsertTable
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
            label2 = new Label();
            nudColumns = new NumericUpDown();
            nudRows = new NumericUpDown();
            BtnOK = new Button();
            BtnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)nudColumns).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 0;
            label1.Text = "Number of columns: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 51);
            label2.Name = "label2";
            label2.Size = new Size(119, 20);
            label2.TabIndex = 1;
            label2.Text = "Number of rows:";
            // 
            // nudColumns
            // 
            nudColumns.Location = new Point(167, 10);
            nudColumns.Margin = new Padding(3, 4, 3, 4);
            nudColumns.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudColumns.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudColumns.Name = "nudColumns";
            nudColumns.Size = new Size(65, 27);
            nudColumns.TabIndex = 2;
            nudColumns.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // nudRows
            // 
            nudRows.Location = new Point(167, 45);
            nudRows.Margin = new Padding(3, 4, 3, 4);
            nudRows.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudRows.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudRows.Name = "nudRows";
            nudRows.Size = new Size(65, 27);
            nudRows.TabIndex = 3;
            nudRows.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // BtnOK
            // 
            BtnOK.Location = new Point(45, 87);
            BtnOK.Margin = new Padding(3, 4, 3, 4);
            BtnOK.Name = "BtnOK";
            BtnOK.Size = new Size(86, 31);
            BtnOK.TabIndex = 4;
            BtnOK.Text = "OK";
            BtnOK.UseVisualStyleBackColor = true;
            BtnOK.Click += BtnOK_Click;
            // 
            // BtnCancel
            // 
            BtnCancel.Location = new Point(137, 87);
            BtnCancel.Margin = new Padding(3, 4, 3, 4);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(86, 31);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = true;
            BtnCancel.Click += BtnCancel_Click;
            // 
            // FrmInsertTable
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 132);
            Controls.Add(BtnCancel);
            Controls.Add(BtnOK);
            Controls.Add(nudRows);
            Controls.Add(nudColumns);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInsertTable";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Insert Table";
            KeyDown += FrmInsertTable_KeyDown;
            ((System.ComponentModel.ISupportInitialize)nudColumns).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRows).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown nudColumns;
        private NumericUpDown nudRows;
        private Button BtnOK;
        private Button BtnCancel;
    }
}