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
            pnlMenuTop = new System.Windows.Forms.Panel();
            pnlMenuBottom = new System.Windows.Forms.Panel();
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
            pnlMenutaskbar.Controls.Add(pnlMenuBottom);
            pnlMenutaskbar.Controls.Add(pnlMenuTop);
            pnlMenutaskbar.Location = new Point(0, 78);
            pnlMenutaskbar.Name = "pnlMenutaskbar";
            pnlMenutaskbar.Size = new Size(225, 900);
            pnlMenutaskbar.TabIndex = 2;
            // 
            // pnlMainContent
            // 
            pnlMainContent.Location = new Point(225, 78);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1197, 900);
            pnlMainContent.TabIndex = 3;
            // 
            // cpSearching1
            // 
            cpSearching1.BackColor = Color.FromArgb(37, 100, 207);
            cpSearching1.Location = new Point(545, 0);
            cpSearching1.Name = "cpSearching1";
            cpSearching1.Size = new Size(569, 72);
            cpSearching1.TabIndex = 4;
            // 
            // pnlMenuTop
            // 
            pnlMenuTop.BackColor = SystemColors.WindowFrame;
            pnlMenuTop.Location = new Point(0, 0);
            pnlMenuTop.Name = "pnlMenuTop";
            pnlMenuTop.Size = new Size(225, 403);
            pnlMenuTop.TabIndex = 0;
            // 
            // pnlMenuBottom
            // 
            pnlMenuBottom.BackColor = Color.Yellow;
            pnlMenuBottom.Location = new Point(0, 402);
            pnlMenuBottom.Name = "pnlMenuBottom";
            pnlMenuBottom.Size = new Size(225, 498);
            pnlMenuBottom.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1422, 977);
            Controls.Add(cpSearching1);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlMenutaskbar);
            Controls.Add(pnlTitleMain);
            Name = "Main";
            Text = "CS Todo List";
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
        private System.Windows.Forms.Panel pnlMenuBottom;
        private System.Windows.Forms.Panel pnlMenuTop;
    }
}