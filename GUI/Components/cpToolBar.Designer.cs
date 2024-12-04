namespace GUI.Components
{
    partial class cpToolBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cpToolBar));
            pnlContent_top = new System.Windows.Forms.Panel();
            cb_Sortby = new ComboBox();
            lblTop_arrange = new Label();
            lblTop_currentTime = new Label();
            lblTop_title = new Label();
            pnlContent_top.SuspendLayout();
            SuspendLayout();
            // 
            // pnlContent_top
            // 
            pnlContent_top.BackColor = Color.FromArgb(246, 246, 246);
            pnlContent_top.Controls.Add(cb_Sortby);
            pnlContent_top.Controls.Add(lblTop_arrange);
            pnlContent_top.Controls.Add(lblTop_currentTime);
            pnlContent_top.Controls.Add(lblTop_title);
            pnlContent_top.Location = new Point(0, 0);
            pnlContent_top.Name = "pnlContent_top";
            pnlContent_top.Size = new Size(1040, 136);
            pnlContent_top.TabIndex = 2;
            // 
            // cb_Sortby
            // 
            cb_Sortby.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cb_Sortby.FormattingEnabled = true;
            cb_Sortby.Items.AddRange(new object[] { "Importance", "Due date", "Alphabetically", "Creation date" });
            cb_Sortby.Location = new Point(881, 11);
            cb_Sortby.Margin = new Padding(3, 4, 3, 4);
            cb_Sortby.Name = "cb_Sortby";
            cb_Sortby.Size = new Size(139, 36);
            cb_Sortby.TabIndex = 7;
            cb_Sortby.SelectedIndexChanged += cb_Sortby_SelectedIndexChanged;
            // 
            // lblTop_arrange
            // 
            lblTop_arrange.Cursor = Cursors.Hand;
            lblTop_arrange.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTop_arrange.Image = (Image)resources.GetObject("lblTop_arrange.Image");
            lblTop_arrange.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_arrange.Location = new Point(744, 4);
            lblTop_arrange.Name = "lblTop_arrange";
            lblTop_arrange.Size = new Size(130, 47);
            lblTop_arrange.TabIndex = 3;
            lblTop_arrange.Text = "Sort by";
            lblTop_arrange.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTop_currentTime
            // 
            lblTop_currentTime.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTop_currentTime.Location = new Point(0, 72);
            lblTop_currentTime.Name = "lblTop_currentTime";
            lblTop_currentTime.Size = new Size(216, 36);
            lblTop_currentTime.TabIndex = 2;
            lblTop_currentTime.Text = "label3";
            lblTop_currentTime.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTop_title
            // 
            lblTop_title.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop_title.ImageAlign = ContentAlignment.MiddleLeft;
            lblTop_title.Location = new Point(0, 0);
            lblTop_title.Name = "lblTop_title";
            lblTop_title.Size = new Size(209, 72);
            lblTop_title.TabIndex = 1;
            lblTop_title.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cpToolBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(pnlContent_top);
            Name = "cpToolBar";
            Size = new Size(1040, 139);
            pnlContent_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlContent_top;
        private Label lblTop_category;
        private Label lblTop_arrange;
        private Label lblTop_currentTime;
        private Label lblTop_title;
        private FlowLayoutPanel pnlArrangeBar;
        private Label label1;
        private Label lbl_itemSortby_importance;
        private Label lbl_itemSortby_Duedate;
        private Label lbl_itemSortby_Alphabetically;
        private Label lbl_itemSortby_Creationdate;
        private ComboBox cb_Sortby;
    }
}
