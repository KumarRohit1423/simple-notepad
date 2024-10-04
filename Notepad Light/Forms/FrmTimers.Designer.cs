namespace Notepad_Light.Forms
{
    partial class FrmTimers
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTimers));
            dataGridView1 = new DataGridView();
            DescriptionCol = new DataGridViewTextBoxColumn();
            DateCol = new DataGridViewTextBoxColumn();
            TimeCol = new DataGridViewTextBoxColumn();
            gridViewContextMenuStrip = new ContextMenuStrip(components);
            CopyDescriptionContextMenu = new ToolStripMenuItem();
            CopyTimeContextMenu = new ToolStripMenuItem();
            BtnClearTimers = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            BtnResumeTimer = new Button();
            BtnDeleteSelectedTime = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            gridViewContextMenuStrip.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { DescriptionCol, DateCol, TimeCol });
            dataGridView1.ContextMenuStrip = gridViewContextMenuStrip;
            dataGridView1.Location = new Point(13, 13);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(473, 399);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // DescriptionCol
            // 
            DescriptionCol.HeaderText = "Description";
            DescriptionCol.MinimumWidth = 6;
            DescriptionCol.Name = "DescriptionCol";
            DescriptionCol.ReadOnly = true;
            DescriptionCol.Width = 200;
            // 
            // DateCol
            // 
            DateCol.HeaderText = "Date";
            DateCol.MinimumWidth = 6;
            DateCol.Name = "DateCol";
            DateCol.ReadOnly = true;
            DateCol.Width = 75;
            // 
            // TimeCol
            // 
            TimeCol.HeaderText = "Time";
            TimeCol.MinimumWidth = 6;
            TimeCol.Name = "TimeCol";
            TimeCol.ReadOnly = true;
            TimeCol.Width = 75;
            // 
            // gridViewContextMenuStrip
            // 
            gridViewContextMenuStrip.ImageScalingSize = new Size(20, 20);
            gridViewContextMenuStrip.Items.AddRange(new ToolStripItem[] { CopyDescriptionContextMenu, CopyTimeContextMenu });
            gridViewContextMenuStrip.Name = "gridViewContextMenuStrip";
            gridViewContextMenuStrip.Size = new Size(193, 52);
            // 
            // CopyDescriptionContextMenu
            // 
            CopyDescriptionContextMenu.Name = "CopyDescriptionContextMenu";
            CopyDescriptionContextMenu.Size = new Size(192, 24);
            CopyDescriptionContextMenu.Text = "Copy Description";
            CopyDescriptionContextMenu.Click += CopyDescriptionContextMenu_Click;
            // 
            // CopyTimeContextMenu
            // 
            CopyTimeContextMenu.Name = "CopyTimeContextMenu";
            CopyTimeContextMenu.Size = new Size(192, 24);
            CopyTimeContextMenu.Text = "Copy Time";
            CopyTimeContextMenu.Click += CopyTimeContextMenu_Click;
            // 
            // BtnClearTimers
            // 
            BtnClearTimers.Location = new Point(363, 423);
            BtnClearTimers.Margin = new Padding(3, 4, 3, 4);
            BtnClearTimers.Name = "BtnClearTimers";
            BtnClearTimers.Size = new Size(121, 31);
            BtnClearTimers.TabIndex = 3;
            BtnClearTimers.Text = "Clear All Timers";
            BtnClearTimers.UseVisualStyleBackColor = true;
            BtnClearTimers.Click += BtnClearTimers_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 465);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(498, 26);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(82, 20);
            toolStripStatusLabel1.Text = "Total Time:";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(63, 20);
            toolStripStatusLabel2.Text = "00:00:00";
            // 
            // BtnResumeTimer
            // 
            BtnResumeTimer.Location = new Point(239, 423);
            BtnResumeTimer.Margin = new Padding(3, 4, 3, 4);
            BtnResumeTimer.Name = "BtnResumeTimer";
            BtnResumeTimer.Size = new Size(118, 31);
            BtnResumeTimer.TabIndex = 5;
            BtnResumeTimer.Text = "Resume Timer";
            BtnResumeTimer.UseVisualStyleBackColor = true;
            BtnResumeTimer.Click += BtnResumeTimer_Click;
            // 
            // BtnDeleteSelectedTime
            // 
            BtnDeleteSelectedTime.Location = new Point(81, 423);
            BtnDeleteSelectedTime.Margin = new Padding(3, 4, 3, 4);
            BtnDeleteSelectedTime.Name = "BtnDeleteSelectedTime";
            BtnDeleteSelectedTime.Size = new Size(151, 31);
            BtnDeleteSelectedTime.TabIndex = 6;
            BtnDeleteSelectedTime.Text = "Delete Selected Time";
            BtnDeleteSelectedTime.UseVisualStyleBackColor = true;
            BtnDeleteSelectedTime.Click += BtnDeleteSelectedTime_Click;
            // 
            // FrmTimers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 491);
            Controls.Add(BtnDeleteSelectedTime);
            Controls.Add(BtnResumeTimer);
            Controls.Add(statusStrip1);
            Controls.Add(BtnClearTimers);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmTimers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Timers";
            KeyDown += FrmTimers_KeyDown;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            gridViewContextMenuStrip.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button BtnClearTimers;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private DataGridViewTextBoxColumn DescriptionCol;
        private DataGridViewTextBoxColumn DateCol;
        private DataGridViewTextBoxColumn TimeCol;
        private ContextMenuStrip gridViewContextMenuStrip;
        private ToolStripMenuItem CopyDescriptionContextMenu;
        private ToolStripMenuItem CopyTimeContextMenu;
        private Button BtnResumeTimer;
        private Button BtnDeleteSelectedTime;
    }
}