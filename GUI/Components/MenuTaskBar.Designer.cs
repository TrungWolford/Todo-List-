namespace GUI.Components
{
    partial class MenuTaskBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuTaskBar));
            pnlMenu_top = new System.Windows.Forms.Panel();
            lbl_itemMyday = new Label();
            lbl_itemTasks = new Label();
            lbl_itemImportant = new Label();
            pnlMenu_center = new System.Windows.Forms.Panel();
            lbl_itemNewGroup = new Label();
            pnlMenu_top.SuspendLayout();
            pnlMenu_center.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu_top
            // 
            pnlMenu_top.Controls.Add(lbl_itemMyday);
            pnlMenu_top.Controls.Add(lbl_itemTasks);
            pnlMenu_top.Controls.Add(lbl_itemImportant);
            pnlMenu_top.Location = new Point(-1, -1);
            pnlMenu_top.Name = "pnlMenu_top";
            pnlMenu_top.Size = new Size(208, 277);
            pnlMenu_top.TabIndex = 0;
            // 
            // lbl_itemMyday
            // 
            lbl_itemMyday.BackColor = Color.White;
            lbl_itemMyday.Cursor = Cursors.Hand;
            lbl_itemMyday.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_itemMyday.ForeColor = SystemColors.ControlText;
            lbl_itemMyday.Image = Properties.Resources.sunny;
            lbl_itemMyday.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemMyday.Location = new Point(-1, 51);
            lbl_itemMyday.Margin = new Padding(3, 0, 0, 0);
            lbl_itemMyday.Name = "lbl_itemMyday";
            lbl_itemMyday.Padding = new Padding(10, 0, 0, 5);
            lbl_itemMyday.Size = new Size(213, 50);
            lbl_itemMyday.TabIndex = 0;
            lbl_itemMyday.Text = "My day";
            lbl_itemMyday.TextAlign = ContentAlignment.MiddleCenter;
            lbl_itemMyday.Click += lbl_itemMyday_Click;
            lbl_itemMyday.MouseEnter += lbl_itemMyday_MouseEnter;
            lbl_itemMyday.MouseLeave += lbl_itemMyday_MouseLeave;
            // 
            // lbl_itemTasks
            // 
            lbl_itemTasks.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_itemTasks.Image = (Image)resources.GetObject("lbl_itemTasks.Image");
            lbl_itemTasks.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemTasks.Location = new Point(-1, 197);
            lbl_itemTasks.Name = "lbl_itemTasks";
            lbl_itemTasks.Padding = new Padding(10, 0, 25, 5);
            lbl_itemTasks.Size = new Size(213, 50);
            lbl_itemTasks.TabIndex = 2;
            lbl_itemTasks.Text = "Tasks";
            lbl_itemTasks.TextAlign = ContentAlignment.MiddleCenter;
            lbl_itemTasks.Click += lbl_itemTasks_Click;
            lbl_itemTasks.MouseEnter += lbl_itemTasks_MouseEnter;
            lbl_itemTasks.MouseLeave += lbl_itemTasks_MouseLeave;
            // 
            // lbl_itemImportant
            // 
            lbl_itemImportant.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_itemImportant.Image = (Image)resources.GetObject("lbl_itemImportant.Image");
            lbl_itemImportant.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemImportant.Location = new Point(-1, 129);
            lbl_itemImportant.Name = "lbl_itemImportant";
            lbl_itemImportant.Padding = new Padding(10, 0, 30, 5);
            lbl_itemImportant.Size = new Size(213, 50);
            lbl_itemImportant.TabIndex = 1;
            lbl_itemImportant.Text = "Important";
            lbl_itemImportant.TextAlign = ContentAlignment.MiddleRight;
            lbl_itemImportant.Click += lbl_itemImportant_Click;
            lbl_itemImportant.MouseEnter += lbl_itemImportant_MouseEnter;
            lbl_itemImportant.MouseLeave += lbl_itemImportant_MouseLeave;
            // 
            // pnlMenu_center
            // 
            pnlMenu_center.Controls.Add(lbl_itemNewGroup);
            pnlMenu_center.Location = new Point(-1, 282);
            pnlMenu_center.Name = "pnlMenu_center";
            pnlMenu_center.Size = new Size(208, 571);
            pnlMenu_center.TabIndex = 1;
            // 
            // lbl_itemNewGroup
            // 
            lbl_itemNewGroup.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_itemNewGroup.ForeColor = Color.FromArgb(37, 100, 207);
            lbl_itemNewGroup.Image = (Image)resources.GetObject("lbl_itemNewGroup.Image");
            lbl_itemNewGroup.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemNewGroup.Location = new Point(-1, 35);
            lbl_itemNewGroup.Name = "lbl_itemNewGroup";
            lbl_itemNewGroup.Padding = new Padding(10, 0, 10, 2);
            lbl_itemNewGroup.Size = new Size(209, 42);
            lbl_itemNewGroup.TabIndex = 3;
            lbl_itemNewGroup.Text = "New Group";
            lbl_itemNewGroup.TextAlign = ContentAlignment.MiddleRight;
            lbl_itemNewGroup.MouseEnter += lbl_itemNewGroup_MouseEnter;
            lbl_itemNewGroup.MouseLeave += lbl_itemNewGroup_MouseLeave;
            // 
            // MenuTaskBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(208, 853);
            Controls.Add(pnlMenu_center);
            Controls.Add(pnlMenu_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuTaskBar";
            Text = "MenuTaskBar";
            pnlMenu_top.ResumeLayout(false);
            pnlMenu_center.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu_top;
        private System.Windows.Forms.Panel pnlMenu_center;
        private Label lbl_itemTasks;
        private Label lbl_itemImportant;
        private Label lbl_itemMyday;
        private Label lbl_itemNewGroup;
    }
}