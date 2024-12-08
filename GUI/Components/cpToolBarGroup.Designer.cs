namespace GUI.Components
{
    partial class cpToolBarGroup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cpToolBarGroup));
            pnlContentGroup_top = new System.Windows.Forms.Panel();
            lblTop_memberGroup = new Label();
            cb_SortbyGroup = new ComboBox();
            lblTop_arrangeGroup = new Label();
            lblTop_currentTimeGroup = new Label();
            lblTop_titleGroup = new Label();
            pnlContentGroup_top.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContentGroup_top
            // 
            pnlContentGroup_top.BackColor = Color.FromArgb(246, 246, 246);
            pnlContentGroup_top.Controls.Add(lblTop_memberGroup);
            pnlContentGroup_top.Controls.Add(cb_SortbyGroup);
            pnlContentGroup_top.Controls.Add(lblTop_arrangeGroup);
            pnlContentGroup_top.Controls.Add(lblTop_currentTimeGroup);
            pnlContentGroup_top.Controls.Add(lblTop_titleGroup);
            pnlContentGroup_top.Dock = DockStyle.Fill;
            pnlContentGroup_top.Location = new Point(0, 0);
            pnlContentGroup_top.Name = "pnlContentGroup_top";
            pnlContentGroup_top.Size = new Size(1040, 136);
            pnlContentGroup_top.TabIndex = 0;
            // 
            // lblTop_memberGroup
            // 
            lblTop_memberGroup.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop_memberGroup.Image = Properties.Resources.groupMember_32px;
            lblTop_memberGroup.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_memberGroup.Location = new Point(901, 11);
            lblTop_memberGroup.Name = "lblTop_memberGroup";
            lblTop_memberGroup.Size = new Size(139, 36);
            lblTop_memberGroup.TabIndex = 9;
            lblTop_memberGroup.Text = "label1";
            lblTop_memberGroup.TextAlign = ContentAlignment.MiddleCenter;
            lblTop_memberGroup.Click += lblTop_memberGroup_Click;
            lblTop_memberGroup.MouseEnter += lblTop_memberGroup_MouseEnter;
            lblTop_memberGroup.MouseLeave += lblTop_memberGroup_MouseLeave;
            // 
            // cb_SortbyGroup
            // 
            cb_SortbyGroup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_SortbyGroup.FormattingEnabled = true;
            cb_SortbyGroup.Items.AddRange(new object[] { "Importance", "Due date", "Alphabetically", "Creation date" });
            cb_SortbyGroup.Location = new Point(701, 11);
            cb_SortbyGroup.Margin = new Padding(3, 4, 3, 4);
            cb_SortbyGroup.Name = "cb_SortbyGroup";
            cb_SortbyGroup.Size = new Size(139, 36);
            cb_SortbyGroup.TabIndex = 8;
            // 
            // lblTop_arrangeGroup
            // 
            lblTop_arrangeGroup.Cursor = Cursors.Hand;
            lblTop_arrangeGroup.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop_arrangeGroup.Image = (Image)resources.GetObject("lblTop_arrangeGroup.Image");
            lblTop_arrangeGroup.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_arrangeGroup.Location = new Point(565, 4);
            lblTop_arrangeGroup.Name = "lblTop_arrangeGroup";
            lblTop_arrangeGroup.Size = new Size(130, 47);
            lblTop_arrangeGroup.TabIndex = 4;
            lblTop_arrangeGroup.Text = "Sort by";
            lblTop_arrangeGroup.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTop_currentTimeGroup
            // 
            lblTop_currentTimeGroup.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTop_currentTimeGroup.Location = new Point(0, 72);
            lblTop_currentTimeGroup.Name = "lblTop_currentTimeGroup";
            lblTop_currentTimeGroup.Size = new Size(216, 36);
            lblTop_currentTimeGroup.TabIndex = 3;
            lblTop_currentTimeGroup.Text = "label3";
            lblTop_currentTimeGroup.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTop_titleGroup
            // 
            lblTop_titleGroup.AutoEllipsis = true;
            lblTop_titleGroup.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop_titleGroup.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_titleGroup.Location = new Point(0, 0);
            lblTop_titleGroup.Name = "lblTop_titleGroup";
            lblTop_titleGroup.Size = new Size(397, 72);
            lblTop_titleGroup.TabIndex = 2;
            lblTop_titleGroup.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cpToolBarGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlContentGroup_top);
            Name = "cpToolBarGroup";
            Size = new Size(1040, 136);
            pnlContentGroup_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContentGroup_top;
        private Label lblTop_titleGroup;
        private Label lblTop_currentTimeGroup;
        private Label lblTop_arrangeGroup;
        private ComboBox cb_SortbyGroup;
        private Label lblTop_memberGroup;
    }
}
