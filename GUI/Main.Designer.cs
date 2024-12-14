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
            button1 = new Button();
            pnlMainContent = new System.Windows.Forms.Panel();
            cpSearching1 = new Components.cpSearching();
            lbl_titleInfoUser = new Label();
            pnlTitleMain.SuspendLayout();
            pnlMenutaskbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitleMain
            // 
            pnlTitleMain.BackColor = Color.FromArgb(37, 100, 207);
            pnlTitleMain.Controls.Add(lbl_titleMain);
            pnlTitleMain.Dock = DockStyle.Top;
            pnlTitleMain.Location = new Point(0, 0);
            pnlTitleMain.Name = "pnlTitleMain";
            pnlTitleMain.Size = new Size(1244, 60);
            pnlTitleMain.TabIndex = 1;
            // 
            // lbl_titleMain
            // 
            lbl_titleMain.AutoSize = true;
            lbl_titleMain.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titleMain.ForeColor = Color.White;
            lbl_titleMain.Location = new Point(10, 10);
            lbl_titleMain.Name = "lbl_titleMain";
            lbl_titleMain.Size = new Size(173, 37);
            lbl_titleMain.TabIndex = 0;
            lbl_titleMain.Text = "CS Todo List";
            lbl_titleMain.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlMenutaskbar
            // 
            pnlMenutaskbar.BackColor = Color.White;
            pnlMenutaskbar.Controls.Add(button1);
            pnlMenutaskbar.Dock = DockStyle.Left;
            pnlMenutaskbar.Location = new Point(0, 60);
            pnlMenutaskbar.Margin = new Padding(3, 2, 3, 2);
            pnlMenutaskbar.Name = "pnlMenutaskbar";
            pnlMenutaskbar.Size = new Size(197, 673);
            pnlMenutaskbar.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 643);
            button1.Name = "button1";
            button1.Size = new Size(197, 30);
            button1.TabIndex = 0;
            button1.Text = "Đăng xuất";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Dock = DockStyle.Fill;
            pnlMainContent.Location = new Point(197, 60);
            pnlMainContent.Margin = new Padding(3, 2, 3, 2);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1047, 673);
            pnlMainContent.TabIndex = 3;
            // 
            // cpSearching1
            // 
            cpSearching1.BackColor = Color.FromArgb(37, 100, 207);
            cpSearching1.Location = new Point(432, 0);
            cpSearching1.Margin = new Padding(3, 2, 3, 2);
            cpSearching1.Name = "cpSearching1";
            cpSearching1.Size = new Size(498, 54);
            cpSearching1.TabIndex = 4;
            // 
            // lbl_titleInfoUser
            // 
            lbl_titleInfoUser.BackColor = Color.FromArgb(37, 100, 207);
            lbl_titleInfoUser.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titleInfoUser.ForeColor = Color.White;
            lbl_titleInfoUser.Location = new Point(1061, 12);
            lbl_titleInfoUser.Name = "lbl_titleInfoUser";
            lbl_titleInfoUser.Size = new Size(172, 34);
            lbl_titleInfoUser.TabIndex = 5;
            lbl_titleInfoUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1244, 733);
            Controls.Add(lbl_titleInfoUser);
            Controls.Add(cpSearching1);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlMenutaskbar);
            Controls.Add(pnlTitleMain);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Main";
            Text = "CS Todo List";
            FormClosed += Main_FormClosed;
            pnlTitleMain.ResumeLayout(false);
            pnlTitleMain.PerformLayout();
            pnlMenutaskbar.ResumeLayout(false);
            ResumeLayout(false);
        }
        #endregion
        private Label pnlTitleMain;
        private Label lbl_titleMain;
        private System.Windows.Forms.Panel pnlMenutaskbar;
        private System.Windows.Forms.Panel pnlMainContent;
        private Components.cpSearching cpSearching1;
        private Label lbl_titleInfoUser;
        private Button button1;
    }
}