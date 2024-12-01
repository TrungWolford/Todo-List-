namespace GUI.Panel
{
    partial class Myday
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myday));
            pnlContentMD_bottom = new System.Windows.Forms.Panel();
            tableMyday = new DataGridView();
            clTitle_md = new DataGridViewTextBoxColumn();
            clDuedate_md = new DataGridViewTextBoxColumn();
            clImportance_md = new DataGridViewImageColumn();
            clDone_md = new DataGridViewImageColumn();
            pnlContentMD_center = new System.Windows.Forms.Panel();
            lblMd_importantSelected = new Label();
            btnMd_add = new Button();
            lblMd_important = new Label();
            lblMd_calendar = new Label();
            txtMydayTask = new TextBox();
            cpToolBar1 = new Components.cpToolBar();
            toolTip_mdCalendar = new ToolTip(components);
            toolTip_mdImportant = new ToolTip(components);
            toolTip_mdImportantSelected = new ToolTip(components);
            pnlContentMD_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableMyday).BeginInit();
            pnlContentMD_center.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentMD_bottom
            // 
            pnlContentMD_bottom.BackColor = Color.White;
            pnlContentMD_bottom.Controls.Add(tableMyday);
            pnlContentMD_bottom.Location = new Point(62, 223);
            pnlContentMD_bottom.Margin = new Padding(3, 2, 3, 2);
            pnlContentMD_bottom.Name = "pnlContentMD_bottom";
            pnlContentMD_bottom.Size = new Size(910, 394);
            pnlContentMD_bottom.TabIndex = 1;
            // 
            // tableMyday
            // 
            tableMyday.AllowUserToAddRows = false;
            tableMyday.AllowUserToDeleteRows = false;
            tableMyday.AllowUserToResizeColumns = false;
            tableMyday.AllowUserToResizeRows = false;
            tableMyday.BackgroundColor = Color.White;
            tableMyday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableMyday.Columns.AddRange(new DataGridViewColumn[] { clTitle_md, clDuedate_md, clImportance_md, clDone_md });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(246, 246, 246);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tableMyday.DefaultCellStyle = dataGridViewCellStyle1;
            tableMyday.Dock = DockStyle.Fill;
            tableMyday.Location = new Point(0, 0);
            tableMyday.Margin = new Padding(3, 2, 3, 2);
            tableMyday.Name = "tableMyday";
            tableMyday.RowHeadersWidth = 51;
            tableMyday.Size = new Size(910, 394);
            tableMyday.TabIndex = 0;
            tableMyday.CellContentClick += tableMyday_CellContentClick;
            // 
            // clTitle_md
            // 
            clTitle_md.FillWeight = 518.743652F;
            clTitle_md.HeaderText = "Title";
            clTitle_md.MinimumWidth = 6;
            clTitle_md.Name = "clTitle_md";
            clTitle_md.ReadOnly = true;
            clTitle_md.Width = 640;
            // 
            // clDuedate_md
            // 
            clDuedate_md.FillWeight = 127.232323F;
            clDuedate_md.HeaderText = "Due date";
            clDuedate_md.MinimumWidth = 6;
            clDuedate_md.Name = "clDuedate_md";
            clDuedate_md.ReadOnly = true;
            clDuedate_md.Width = 157;
            // 
            // clImportance_md
            // 
            clImportance_md.FillWeight = 96.04276F;
            clImportance_md.HeaderText = "Importance";
            clImportance_md.Image = Properties.Resources.Important_24px;
            clImportance_md.MinimumWidth = 6;
            clImportance_md.Name = "clImportance_md";
            clImportance_md.ReadOnly = true;
            clImportance_md.Resizable = DataGridViewTriState.True;
            clImportance_md.SortMode = DataGridViewColumnSortMode.Automatic;
            clImportance_md.Width = 118;
            // 
            // clDone_md
            // 
            clDone_md.FillWeight = 57.9811935F;
            clDone_md.HeaderText = "Done";
            clDone_md.Image = Properties.Resources.notDone_24;
            clDone_md.MinimumWidth = 6;
            clDone_md.Name = "clDone_md";
            clDone_md.ReadOnly = true;
            clDone_md.Resizable = DataGridViewTriState.True;
            clDone_md.SortMode = DataGridViewColumnSortMode.Automatic;
            clDone_md.Width = 72;
            // 
            // pnlContentMD_center
            // 
            pnlContentMD_center.BackColor = Color.White;
            pnlContentMD_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentMD_center.Controls.Add(lblMd_importantSelected);
            pnlContentMD_center.Controls.Add(btnMd_add);
            pnlContentMD_center.Controls.Add(lblMd_important);
            pnlContentMD_center.Controls.Add(lblMd_calendar);
            pnlContentMD_center.Controls.Add(txtMydayTask);
            pnlContentMD_center.Location = new Point(62, 125);
            pnlContentMD_center.Margin = new Padding(3, 2, 3, 2);
            pnlContentMD_center.Name = "pnlContentMD_center";
            pnlContentMD_center.Size = new Size(910, 82);
            pnlContentMD_center.TabIndex = 1;
            // 
            // lblMd_importantSelected
            // 
            lblMd_importantSelected.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMd_importantSelected.Cursor = Cursors.Hand;
            lblMd_importantSelected.Image = (Image)resources.GetObject("lblMd_importantSelected.Image");
            lblMd_importantSelected.Location = new Point(59, 38);
            lblMd_importantSelected.Name = "lblMd_importantSelected";
            lblMd_importantSelected.Size = new Size(50, 33);
            lblMd_importantSelected.TabIndex = 4;
            toolTip_mdImportantSelected.SetToolTip(lblMd_importantSelected, "Remove importance level");
            lblMd_importantSelected.Visible = false;
            lblMd_importantSelected.Click += lblMd_importantSelected_Click;
            // 
            // btnMd_add
            // 
            btnMd_add.Location = new Point(811, 38);
            btnMd_add.Margin = new Padding(3, 2, 3, 2);
            btnMd_add.Name = "btnMd_add";
            btnMd_add.Size = new Size(82, 33);
            btnMd_add.TabIndex = 3;
            btnMd_add.Text = "Add";
            btnMd_add.UseVisualStyleBackColor = true;
            btnMd_add.Click += btnMd_add_Click;
            // 
            // lblMd_important
            // 
            lblMd_important.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMd_important.Cursor = Cursors.Hand;
            lblMd_important.Image = (Image)resources.GetObject("lblMd_important.Image");
            lblMd_important.Location = new Point(59, 38);
            lblMd_important.Name = "lblMd_important";
            lblMd_important.Size = new Size(50, 33);
            lblMd_important.TabIndex = 2;
            toolTip_mdImportant.SetToolTip(lblMd_important, "Mark the task as important");
            lblMd_important.Click += lblMd_important_Click;
            // 
            // lblMd_calendar
            // 
            lblMd_calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMd_calendar.Cursor = Cursors.Hand;
            lblMd_calendar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMd_calendar.Image = Properties.Resources.calendar;
            lblMd_calendar.ImageAlign = ContentAlignment.MiddleLeft;
            lblMd_calendar.Location = new Point(13, 38);
            lblMd_calendar.Name = "lblMd_calendar";
            lblMd_calendar.Size = new Size(149, 33);
            lblMd_calendar.TabIndex = 1;
            lblMd_calendar.TextAlign = ContentAlignment.MiddleRight;
            toolTip_mdCalendar.SetToolTip(lblMd_calendar, "Add Due Date");
            lblMd_calendar.Click += lblMd_calendar_Click;
            // 
            // txtMydayTask
            // 
            txtMydayTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMydayTask.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMydayTask.Location = new Point(-2, -2);
            txtMydayTask.Margin = new Padding(3, 2, 3, 2);
            txtMydayTask.Name = "txtMydayTask";
            txtMydayTask.PlaceholderText = "New task";
            txtMydayTask.Size = new Size(906, 32);
            txtMydayTask.TabIndex = 0;
            // 
            // cpToolBar1
            // 
            cpToolBar1.BackColor = Color.Transparent;
            cpToolBar1.Location = new Point(62, 23);
            cpToolBar1.Margin = new Padding(3, 2, 3, 2);
            cpToolBar1.Name = "cpToolBar1";
            cpToolBar1.Size = new Size(910, 81);
            cpToolBar1.TabIndex = 2;
            // 
            // Myday
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1032, 640);
            Controls.Add(cpToolBar1);
            Controls.Add(pnlContentMD_center);
            Controls.Add(pnlContentMD_bottom);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Myday";
            Text = "Myday";
            Load += Myday_Load;
            pnlContentMD_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableMyday).EndInit();
            pnlContentMD_center.ResumeLayout(false);
            pnlContentMD_center.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Panel pnlContentMD_bottom;
        private System.Windows.Forms.Panel pnlContentMD_center;
        private TextBox txtMydayTask;
        private Label lblMd_calendar;
        private Label lblMd_important;
        private Button btnMd_add;
        private DataGridView tableMyday;
        private Components.cpToolBar cpToolBar1;
        private ToolTip toolTip_mdCalendar;
        private Label lblMd_importantSelected;
        private ToolTip toolTip_mdImportantSelected;
        private ToolTip toolTip_mdImportant;
        private DataGridViewTextBoxColumn clTitle_md;
        private DataGridViewTextBoxColumn clDuedate_md;
        private DataGridViewImageColumn clImportance_md;
        private DataGridViewImageColumn clDone_md;
    }
}