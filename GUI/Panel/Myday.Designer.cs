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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Myday));
            pnlContentMD_bottom = new System.Windows.Forms.Panel();
            tableMyday = new DataGridView();
            clTitle_md = new DataGridViewTextBoxColumn();
            clDuedate_md = new DataGridViewTextBoxColumn();
            clImportance_md = new DataGridViewTextBoxColumn();
            clDone_md = new DataGridViewTextBoxColumn();
            pnlContentMD_center = new System.Windows.Forms.Panel();
            btnMd_add = new Button();
            lblMd_important = new Label();
            lblMd_calendar = new Label();
            txtMydayTask = new TextBox();
            cpToolBar1 = new Components.cpToolBar(this);
            pnlContentMD_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableMyday).BeginInit();
            pnlContentMD_center.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentMD_bottom
            // 
            pnlContentMD_bottom.BackColor = Color.White;
            pnlContentMD_bottom.Controls.Add(tableMyday);
            pnlContentMD_bottom.Location = new Point(71, 297);
            pnlContentMD_bottom.Name = "pnlContentMD_bottom";
            pnlContentMD_bottom.Size = new Size(1040, 525);
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
            tableMyday.Dock = DockStyle.Fill;
            tableMyday.Location = new Point(0, 0);
            tableMyday.Name = "tableMyday";
            tableMyday.RowHeadersWidth = 51;
            tableMyday.Size = new Size(1040, 525);
            tableMyday.TabIndex = 0;
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
            clImportance_md.MinimumWidth = 6;
            clImportance_md.Name = "clImportance_md";
            clImportance_md.ReadOnly = true;
            clImportance_md.Width = 118;
            // 
            // clDone_md
            // 
            clDone_md.FillWeight = 57.9811935F;
            clDone_md.HeaderText = "Done";
            clDone_md.MinimumWidth = 6;
            clDone_md.Name = "clDone_md";
            clDone_md.ReadOnly = true;
            clDone_md.Width = 72;
            // 
            // pnlContentMD_center
            // 
            pnlContentMD_center.BackColor = Color.White;
            pnlContentMD_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContentMD_center.Controls.Add(btnMd_add);
            pnlContentMD_center.Controls.Add(lblMd_important);
            pnlContentMD_center.Controls.Add(lblMd_calendar);
            pnlContentMD_center.Controls.Add(txtMydayTask);
            pnlContentMD_center.Location = new Point(71, 167);
            pnlContentMD_center.Name = "pnlContentMD_center";
            pnlContentMD_center.Size = new Size(1040, 108);
            pnlContentMD_center.TabIndex = 1;
            // 
            // btnMd_add
            // 
            btnMd_add.Location = new Point(927, 51);
            btnMd_add.Name = "btnMd_add";
            btnMd_add.Size = new Size(94, 44);
            btnMd_add.TabIndex = 3;
            btnMd_add.Text = "Add";
            btnMd_add.UseVisualStyleBackColor = true;
            // 
            // lblMd_important
            // 
            lblMd_important.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMd_important.Image = (Image)resources.GetObject("lblMd_important.Image");
            lblMd_important.Location = new Point(66, 51);
            lblMd_important.Name = "lblMd_important";
            lblMd_important.Size = new Size(57, 44);
            lblMd_important.TabIndex = 2;
            // 
            // lblMd_calendar
            // 
            lblMd_calendar.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblMd_calendar.Image = Properties.Resources.calendar;
            lblMd_calendar.Location = new Point(3, 51);
            lblMd_calendar.Name = "lblMd_calendar";
            lblMd_calendar.Size = new Size(57, 44);
            lblMd_calendar.TabIndex = 1;
            // 
            // txtMydayTask
            // 
            txtMydayTask.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtMydayTask.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMydayTask.Location = new Point(-2, -2);
            txtMydayTask.Name = "txtMydayTask";
            txtMydayTask.PlaceholderText = "New task";
            txtMydayTask.Size = new Size(1035, 38);
            txtMydayTask.TabIndex = 0;
            // 
            // cpToolBar1
            // 
            cpToolBar1.Location = new Point(71, 31);
            cpToolBar1.Name = "cpToolBar1";
            cpToolBar1.Size = new Size(1040, 108);
            cpToolBar1.TabIndex = 2;
            // 
            // Myday
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(cpToolBar1);
            Controls.Add(pnlContentMD_center);
            Controls.Add(pnlContentMD_bottom);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Myday";
            Text = "Myday";
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
        private DataGridViewTextBoxColumn clTitle_md;
        private DataGridViewTextBoxColumn clDuedate_md;
        private DataGridViewTextBoxColumn clImportance_md;
        private DataGridViewTextBoxColumn clDone_md;
    }
}