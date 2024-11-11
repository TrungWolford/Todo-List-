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
            pnlContent_top = new System.Windows.Forms.Panel();
            lblTop_category = new Label();
            lblTop_arrange = new Label();
            lblTop_currentTime = new Label();
            lblTop_title = new Label();
            pnlContent_bottom = new System.Windows.Forms.Panel();
            tableMyday = new DataGridView();
            pnlContent_center = new System.Windows.Forms.Panel();
            btnMd_add = new Button();
            lblMd_important = new Label();
            lblMd_calendar = new Label();
            txtMydayTask = new TextBox();
            clTitle = new DataGridViewTextBoxColumn();
            clDuedate = new DataGridViewTextBoxColumn();
            clImportance = new DataGridViewTextBoxColumn();
            clDone = new DataGridViewTextBoxColumn();
            pnlContent_top.SuspendLayout();
            pnlContent_bottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tableMyday).BeginInit();
            pnlContent_center.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent_top
            // 
            pnlContent_top.BackColor = Color.FromArgb(246, 246, 246);
            pnlContent_top.Controls.Add(lblTop_category);
            pnlContent_top.Controls.Add(lblTop_arrange);
            pnlContent_top.Controls.Add(lblTop_currentTime);
            pnlContent_top.Controls.Add(lblTop_title);
            pnlContent_top.Location = new Point(71, 41);
            pnlContent_top.Name = "pnlContent_top";
            pnlContent_top.Size = new Size(1040, 108);
            pnlContent_top.TabIndex = 0;
            // 
            // lblTop_category
            // 
            lblTop_category.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop_category.Image = (Image)resources.GetObject("lblTop_category.Image");
            lblTop_category.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_category.Location = new Point(899, 0);
            lblTop_category.Name = "lblTop_category";
            lblTop_category.Size = new Size(141, 47);
            lblTop_category.TabIndex = 4;
            lblTop_category.Text = "Category";
            lblTop_category.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTop_arrange
            // 
            lblTop_arrange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop_arrange.Image = (Image)resources.GetObject("lblTop_arrange.Image");
            lblTop_arrange.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_arrange.Location = new Point(744, 0);
            lblTop_arrange.Name = "lblTop_arrange";
            lblTop_arrange.Size = new Size(130, 47);
            lblTop_arrange.TabIndex = 3;
            lblTop_arrange.Text = "Arrange";
            lblTop_arrange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTop_currentTime
            // 
            lblTop_currentTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTop_currentTime.Location = new Point(0, 78);
            lblTop_currentTime.Name = "lblTop_currentTime";
            lblTop_currentTime.Size = new Size(216, 19);
            lblTop_currentTime.TabIndex = 2;
            lblTop_currentTime.Text = "label3";
            lblTop_currentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTop_title
            // 
            lblTop_title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop_title.Image = Properties.Resources.sunny2;
            lblTop_title.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_title.Location = new Point(0, 0);
            lblTop_title.Name = "lblTop_title";
            lblTop_title.Size = new Size(209, 72);
            lblTop_title.TabIndex = 1;
            lblTop_title.Text = "My day";
            lblTop_title.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlContent_bottom
            // 
            pnlContent_bottom.BackColor = Color.White;
            pnlContent_bottom.Controls.Add(tableMyday);
            pnlContent_bottom.Location = new Point(71, 297);
            pnlContent_bottom.Name = "pnlContent_bottom";
            pnlContent_bottom.Size = new Size(1040, 525);
            pnlContent_bottom.TabIndex = 1;
            // 
            // tableMyday
            // 
            tableMyday.AllowUserToAddRows = false;
            tableMyday.AllowUserToDeleteRows = false;
            tableMyday.AllowUserToResizeColumns = false;
            tableMyday.AllowUserToResizeRows = false;
            tableMyday.BackgroundColor = Color.White;
            tableMyday.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableMyday.Columns.AddRange(new DataGridViewColumn[] { clTitle, clDuedate, clImportance, clDone });
            tableMyday.Dock = DockStyle.Fill;
            tableMyday.Location = new Point(0, 0);
            tableMyday.Name = "tableMyday";
            tableMyday.RowHeadersWidth = 51;
            tableMyday.Size = new Size(1040, 525);
            tableMyday.TabIndex = 0;
            // 
            // pnlContent_center
            // 
            pnlContent_center.BackColor = Color.White;
            pnlContent_center.BorderStyle = BorderStyle.Fixed3D;
            pnlContent_center.Controls.Add(btnMd_add);
            pnlContent_center.Controls.Add(lblMd_important);
            pnlContent_center.Controls.Add(lblMd_calendar);
            pnlContent_center.Controls.Add(txtMydayTask);
            pnlContent_center.Location = new Point(71, 167);
            pnlContent_center.Name = "pnlContent_center";
            pnlContent_center.Size = new Size(1040, 108);
            pnlContent_center.TabIndex = 1;
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
            txtMydayTask.Size = new Size(1035, 38);
            txtMydayTask.TabIndex = 0;
            // 
            // clTitle
            // 
            clTitle.FillWeight = 518.743652F;
            clTitle.HeaderText = "Title";
            clTitle.MinimumWidth = 6;
            clTitle.Name = "clTitle";
            clTitle.ReadOnly = true;
            clTitle.Width = 640;
            // 
            // clDuedate
            // 
            clDuedate.FillWeight = 127.232323F;
            clDuedate.HeaderText = "Due date";
            clDuedate.MinimumWidth = 6;
            clDuedate.Name = "clDuedate";
            clDuedate.ReadOnly = true;
            clDuedate.Width = 157;
            // 
            // clImportance
            // 
            clImportance.FillWeight = 96.04276F;
            clImportance.HeaderText = "Importance";
            clImportance.MinimumWidth = 6;
            clImportance.Name = "clImportance";
            clImportance.ReadOnly = true;
            clImportance.Width = 118;
            // 
            // clDone
            // 
            clDone.FillWeight = 57.9811935F;
            clDone.HeaderText = "Done";
            clDone.MinimumWidth = 6;
            clDone.Name = "clDone";
            clDone.ReadOnly = true;
            clDone.Width = 72;
            // 
            // Myday
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1179, 853);
            Controls.Add(pnlContent_center);
            Controls.Add(pnlContent_bottom);
            Controls.Add(pnlContent_top);
            Name = "Myday";
            Text = "Myday";
            pnlContent_top.ResumeLayout(false);
            pnlContent_bottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tableMyday).EndInit();
            pnlContent_center.ResumeLayout(false);
            pnlContent_center.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent_top;
        private System.Windows.Forms.Panel pnlContent_bottom;
        private System.Windows.Forms.Panel pnlContent_center;
        private Label lblTop_title;
        private Label lblTop_currentTime;
        private Label lblTop_arrange;
        private Label lblTop_category;
        private TextBox txtMydayTask;
        private Label lblMd_calendar;
        private Label lblMd_important;
        private Button btnMd_add;
        private DataGridView tableMyday;
        private DataGridViewTextBoxColumn clTitle;
        private DataGridViewTextBoxColumn clDuedate;
        private DataGridViewTextBoxColumn clImportance;
        private DataGridViewTextBoxColumn clDone;
    }
}