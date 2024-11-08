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
            pnlMenuTaskBar = new FlowLayoutPanel();
            pnlTitleMain = new Panel();
            lbl_titleMain = new Label();
            pnlMainContent = new Panel();
            pnlTitleMain.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenuTaskBar
            // 
            pnlMenuTaskBar.BackColor = Color.White;
            pnlMenuTaskBar.Location = new Point(0, 63);
            pnlMenuTaskBar.Name = "pnlMenuTaskBar";
            pnlMenuTaskBar.Size = new Size(235, 914);
            pnlMenuTaskBar.TabIndex = 0;
            // 
            // pnlTitleMain
            // 
            pnlTitleMain.BackColor = Color.FromArgb(37, 100, 207);
            pnlTitleMain.Controls.Add(lbl_titleMain);
            pnlTitleMain.Dock = DockStyle.Top;
            pnlTitleMain.Location = new Point(0, 0);
            pnlTitleMain.Name = "pnlTitleMain";
            pnlTitleMain.Size = new Size(1422, 75);
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
            // pnlMainContent
            // 
            pnlMainContent.Location = new Point(236, 76);
            pnlMainContent.Name = "pnlMainContent";
            pnlMainContent.Size = new Size(1186, 901);
            pnlMainContent.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(246, 246, 246);
            ClientSize = new Size(1422, 977);
            Controls.Add(pnlMainContent);
            Controls.Add(pnlTitleMain);
            Controls.Add(pnlMenuTaskBar);
            Name = "Main";
            Text = "CS Todo List";
            pnlTitleMain.ResumeLayout(false);
            pnlTitleMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlMenuTaskBar;
        private Panel pnlTitleMain;
        private Label lbl_titleMain;
        private Panel pnlMainContent;
    }
}