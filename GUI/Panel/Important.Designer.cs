namespace GUI.Panel
{
    partial class Important
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Important));
            cpToolBar = new Components.cpToolBar(this);
            pnlContentImp_center = new System.Windows.Forms.Panel();
            btnImp_add = new Button();
            lblImp_important = new Label();
            lblImp_calendar = new Label();
            txtImportantTask = new TextBox();
            pnlContentImp_bottom = new System.Windows.Forms.Panel();
            tableMyday = new DataGridView();
            clTitle_imp = new DataGridViewTextBoxColumn();
            clDuedate_imp = new DataGridViewTextBoxColumn();
            clImportance_imp = new DataGridViewTextBoxColumn();
            clDone_imp = new DataGridViewTextBoxColumn();
            pnlContentImp_center.SuspendLayout();
            pnlContentImp_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableMyday).BeginInit();
            SuspendLayout();
            // 
            // cpToolBar
            // 
            cpToolBar.BackColor = SystemColors.ControlDark;
            cpToolBar.Location = new Point(71, 31);
            cpToolBar.Name = "cpToolBar";
            cpToolBar.Size = new Size(1040, 108);
            cpToolBar.TabIndex = 0;
            // 
            // pnlContentImp_center
            // 
            pnlContentImp_center.BackColor = Color.White;
            pnlContentImp_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentImp_center.Controls.Add(btnImp_add);
            pnlContentImp_center.Controls.Add(lblImp_important);
            pnlContentImp_center.Controls.Add(lblImp_calendar);
            pnlContentImp_center.Controls.Add(txtImportantTask);
            pnlContentImp_center.Location = new Point(71, 167);
            pnlContentImp_center.Name = "pnlContentImp_center";
            pnlContentImp_center.Size = new Size(1040, 108);
            pnlContentImp_center.TabIndex = 2;
            // 
            // btnImp_add
            // 
            btnImp_add.Location = new Point(927, 51);
            btnImp_add.Name = "btnImp_add";
            btnImp_add.Size = new Size(94, 44);
            btnImp_add.TabIndex = 3;
            btnImp_add.Text = "Add";
            btnImp_add.UseVisualStyleBackColor = true;
            // 
            // lblImp_important
            // 
            lblImp_important.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImp_important.Image = (Image)resources.GetObject("lblImp_important.Image");
            lblImp_important.Location = new Point(66, 55);
            lblImp_important.Name = "lblImp_important";
            lblImp_important.Size = new Size(57, 44);
            lblImp_important.TabIndex = 2;
            // 
            // lblImp_calendar
            // 
            lblImp_calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblImp_calendar.Image = Properties.Resources.calendar;
            lblImp_calendar.Location = new Point(3, 55);
            lblImp_calendar.Name = "lblImp_calendar";
            lblImp_calendar.Size = new Size(57, 44);
            lblImp_calendar.TabIndex = 1;
            // 
            // txtImportantTask
            // 
            txtImportantTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtImportantTask.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtImportantTask.Location = new Point(-2, -2);
            txtImportantTask.Name = "txtImportantTask";
            txtImportantTask.PlaceholderText = "New task";
            txtImportantTask.Size = new Size(1035, 38);
            txtImportantTask.TabIndex = 0;
            // 
            // pnlContentImp_bottom
            // 
            pnlContentImp_bottom.Controls.Add(tableMyday);
            pnlContentImp_bottom.Location = new Point(71, 297);
            pnlContentImp_bottom.Name = "pnlContentImp_bottom";
            pnlContentImp_bottom.Size = new Size(1040, 525);
            pnlContentImp_bottom.TabIndex = 3;
            // 
            // tableMyday
            // 
            tableMyday.AllowUserToAddRows = false;
            tableMyday.AllowUserToDeleteRows = false;
            tableMyday.AllowUserToResizeColumns = false;
            tableMyday.AllowUserToResizeRows = false;
            tableMyday.BackgroundColor = Color.White;
            tableMyday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableMyday.Columns.AddRange(new DataGridViewColumn[] { clTitle_imp, clDuedate_imp, clImportance_imp, clDone_imp });
            tableMyday.Dock = DockStyle.Fill;
            tableMyday.Location = new Point(0, 0);
            tableMyday.Name = "tableMyday";
            tableMyday.RowHeadersWidth = 51;
            tableMyday.Size = new Size(1040, 525);
            tableMyday.TabIndex = 1;
            // 
            // clTitle_imp
            // 
            clTitle_imp.FillWeight = 518.743652F;
            clTitle_imp.HeaderText = "Title";
            clTitle_imp.MinimumWidth = 6;
            clTitle_imp.Name = "clTitle_imp";
            clTitle_imp.ReadOnly = true;
            clTitle_imp.Width = 640;
            // 
            // clDuedate_imp
            // 
            clDuedate_imp.FillWeight = 127.232323F;
            clDuedate_imp.HeaderText = "Due date";
            clDuedate_imp.MinimumWidth = 6;
            clDuedate_imp.Name = "clDuedate_imp";
            clDuedate_imp.ReadOnly = true;
            clDuedate_imp.Width = 157;
            // 
            // clImportance_imp
            // 
            clImportance_imp.FillWeight = 96.04276F;
            clImportance_imp.HeaderText = "Importance";
            clImportance_imp.MinimumWidth = 6;
            clImportance_imp.Name = "clImportance_imp";
            clImportance_imp.ReadOnly = true;
            clImportance_imp.Width = 118;
            // 
            // clDone_imp
            // 
            clDone_imp.FillWeight = 57.9811935F;
            clDone_imp.HeaderText = "Done";
            clDone_imp.MinimumWidth = 6;
            clDone_imp.Name = "clDone_imp";
            clDone_imp.ReadOnly = true;
            clDone_imp.Width = 72;
            // 
            // Important
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(pnlContentImp_bottom);
            Controls.Add(pnlContentImp_center);
            Controls.Add(cpToolBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Important";
            Text = "Important";
            pnlContentImp_center.ResumeLayout(false);
            pnlContentImp_center.PerformLayout();
            pnlContentImp_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableMyday).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Components.cpToolBar cpToolBar;
        private System.Windows.Forms.Panel pnlContentImp_center;
        private Button btnImp_add;
        private Label lblImp_important;
        private Label lblImp_calendar;
        private TextBox txtImportantTask;
        private System.Windows.Forms.Panel pnlContentImp_bottom;
        private DataGridView tableMyday;
        private DataGridViewTextBoxColumn clTitle_imp;
        private DataGridViewTextBoxColumn clDuedate_imp;
        private DataGridViewTextBoxColumn clImportance_imp;
        private DataGridViewTextBoxColumn clDone_imp;
    }
}