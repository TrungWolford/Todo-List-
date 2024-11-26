namespace GUI
{
    partial class Main
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
            pnlTitleMain = new Label();
            lbl_titleMain = new Label();
            pnlMenutaskbar = new System.Windows.Forms.Panel();
            pnlMainContent = new System.Windows.Forms.Panel();
            cpSearching1 = new Components.cpSearching();
            lbl_titleInfoUser = new Label();
            pnlTitleMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitleMain
            // 
            pnlTitleMain.BackColor = Color.FromArgb(37, 100, 207);
            pnlTitleMain.Controls.Add(lbl_titleMain);
            pnlTitleMain.Dock = DockStyle.Top;
            pnlTitleMain.Location = new Point(0, 0);
            pnlTitleMain.Name = "pnlTitleMain";
            pnlTitleMain.Size = new Size(1422, 80);
            pnlTitleMain.TabIndex = 1;
            // 
            // lbl_titleMain
            // 
            lbl_titleMain.AutoSize = true;
            lbl_titleMain.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titleMain.ForeColor = Color.White;
            lbl_titleMain.Location = new Point(12, 14);
            lbl_titleMain.Name = "lbl_titleMain";
            lbl_titleMain.Size = new Size(213, 46);
            lbl_titleMain.TabIndex = 0;
            lbl_titleMain.Text = "CS Todo List";
            lbl_titleMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMenutaskbar
            // 
            pnlMenutaskbar.BackColor = Color.White;
            pnlMenutaskbar.Dock = DockStyle.Left;
            pnlMenutaskbar.Location = new Point(0, 80);
            pnlMenutaskbar.Name = "pnlMenutaskbar";
            pnlMenutaskbar.Size = new Size(225, 897);
            pnlMenutaskbar.TabIndex = 2;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(225, 80);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1197, 897);
            pnlMainContent.TabIndex = 3;
            // 
            // cpSearching1
            // 
            cpSearching1.BackColor = Color.FromArgb(37, 100, 207);
            cpSearching1.Location = new Point(494, 0);
            cpSearching1.Name = "cpSearching1";
            cpSearching1.Size = new Size(569, 72);
            cpSearching1.TabIndex = 4;
            // 
            // lbl_titleInfoUser
            // 
            lbl_titleInfoUser.BackColor = Color.FromArgb(37, 100, 207);
            lbl_titleInfoUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titleInfoUser.ForeColor = Color.White;
            lbl_titleInfoUser.Location = new Point(1213, 16);
            lbl_titleInfoUser.Name = "lbl_titleInfoUser";
            lbl_titleInfoUser.Size = new Size(197, 46);
            lbl_titleInfoUser.TabIndex = 5;
            lbl_titleInfoUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1422, 977);
            Controls.Add(lbl_titleInfoUser);
            Controls.Add(cpSearching1);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlMenutaskbar);
            Controls.Add(pnlTitleMain);
            Name = "Main";
            Text = "CS Todo List";
            pnlTitleMain.ResumeLayout(false);
            pnlTitleMain.PerformLayout();
            ResumeLayout(false);
        }
        #endregion
        private Label pnlTitleMain;
        private Label lbl_titleMain;
        private System.Windows.Forms.Panel pnlMenutaskbar;
        private System.Windows.Forms.Panel pnlMainContent;
        private Components.cpSearching cpSearching1;
        private Label lbl_titleInfoUser;
    }
}