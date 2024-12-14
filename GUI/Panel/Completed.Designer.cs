namespace GUI.Panel
{
    partial class Completed
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            cpToolBar1 = new Components.cpToolBar();
            pnlContentCompleted_center = new System.Windows.Forms.Panel();
            tableCompleted = new DataGridView();
            clTitle_cmp = new DataGridViewTextBoxColumn();
            clDuedate_cmp = new DataGridViewTextBoxColumn();
            clImportance_cmp = new DataGridViewImageColumn();
            clDone_cmp = new DataGridViewImageColumn();
            pnlContentCompleted_center.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableCompleted).BeginInit();
            SuspendLayout();
            // 
            // cpToolBar1
            // 
            cpToolBar1.BackColor = Color.Transparent;
            cpToolBar1.Location = new Point(71, 31);
            cpToolBar1.Name = "cpToolBar1";
            cpToolBar1.Size = new Size(1040, 108);
            cpToolBar1.TabIndex = 0;
            cpToolBar1.OnSortByChanged += CpToolBar1_OnSortByChanged;
            cpToolBar1.Load += cpToolBar1_Load;
            // 
            // pnlContentCompleted_center
            // 
            pnlContentCompleted_center.Controls.Add(tableCompleted);
            pnlContentCompleted_center.Location = new Point(71, 167);
            pnlContentCompleted_center.Name = "pnlContentCompleted_center";
            pnlContentCompleted_center.Size = new Size(1040, 650);
            pnlContentCompleted_center.TabIndex = 1;
            // 
            // tableCompleted
            // 
            tableCompleted.AllowUserToAddRows = false;
            tableCompleted.AllowUserToDeleteRows = false;
            tableCompleted.AllowUserToResizeColumns = false;
            tableCompleted.AllowUserToResizeRows = false;
            tableCompleted.BackgroundColor = Color.White;
            tableCompleted.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableCompleted.Columns.AddRange(new DataGridViewColumn[] { clTitle_cmp, clDuedate_cmp, clImportance_cmp, clDone_cmp });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableCompleted.DefaultCellStyle = dataGridViewCellStyle1;
            tableCompleted.Dock = DockStyle.Fill;
            tableCompleted.Location = new Point(0, 0);
            tableCompleted.Name = "tableCompleted";
            tableCompleted.RowHeadersWidth = 51;
            tableCompleted.Size = new Size(1040, 650);
            tableCompleted.TabIndex = 2;
            tableCompleted.CellContentClick += tableCompleted_CellContentClick;
            // 
            // clTitle_cmp
            // 
            clTitle_cmp.FillWeight = 518.743652F;
            clTitle_cmp.HeaderText = "Title";
            clTitle_cmp.MinimumWidth = 6;
            clTitle_cmp.Name = "clTitle_cmp";
            clTitle_cmp.ReadOnly = true;
            clTitle_cmp.Width = 640;
            // 
            // clDuedate_cmp
            // 
            clDuedate_cmp.FillWeight = 127.232323F;
            clDuedate_cmp.HeaderText = "Due date";
            clDuedate_cmp.MinimumWidth = 6;
            clDuedate_cmp.Name = "clDuedate_cmp";
            clDuedate_cmp.ReadOnly = true;
            clDuedate_cmp.Width = 157;
            // 
            // clImportance_cmp
            // 
            clImportance_cmp.FillWeight = 96.04276F;
            clImportance_cmp.HeaderText = "Importance";
            clImportance_cmp.Image = Properties.Resources.Important_24px;
            clImportance_cmp.MinimumWidth = 6;
            clImportance_cmp.Name = "clImportance_cmp";
            clImportance_cmp.ReadOnly = true;
            clImportance_cmp.Resizable = DataGridViewTriState.True;
            clImportance_cmp.SortMode = DataGridViewColumnSortMode.Automatic;
            clImportance_cmp.Width = 118;
            // 
            // clDone_cmp
            // 
            clDone_cmp.FillWeight = 57.9811935F;
            clDone_cmp.HeaderText = "Done";
            clDone_cmp.Image = Properties.Resources.notDone_24;
            clDone_cmp.MinimumWidth = 6;
            clDone_cmp.Name = "clDone_cmp";
            clDone_cmp.ReadOnly = true;
            clDone_cmp.Resizable = DataGridViewTriState.True;
            clDone_cmp.SortMode = DataGridViewColumnSortMode.Automatic;
            clDone_cmp.Width = 72;
            // 
            // Completed
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(pnlContentCompleted_center);
            Controls.Add(cpToolBar1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Completed";
            Text = "Completed";
            Load += Completed_Load;
            pnlContentCompleted_center.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableCompleted).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.cpToolBar cpToolBar1;
        private System.Windows.Forms.Panel pnlContentCompleted_center;
        private DataGridView tableCompleted;
        private DataGridViewTextBoxColumn clTitle_cmp;
        private DataGridViewTextBoxColumn clDuedate_cmp;
        private DataGridViewImageColumn clImportance_cmp;
        private DataGridViewImageColumn clDone_cmp;
    }
}