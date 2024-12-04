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
            lbl_itemCompleted = new Label();
            lbl_itemMyday = new Label();
            lbl_itemTasks = new Label();
            lbl_itemImportant = new Label();
            pnlMenu_center = new System.Windows.Forms.Panel();
            pnlitem_GroupName = new System.Windows.Forms.Panel();
            txtItem_GroupName = new TextBox();
            lblitem_iconGroupName = new Label();
            lbl_itemNewGroup = new Label();
            pnlMenu_bottom = new FlowLayoutPanel();
            pnlMenu_top.SuspendLayout();
            pnlMenu_center.SuspendLayout();
            pnlitem_GroupName.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu_top
            // 
            pnlMenu_top.Controls.Add(lbl_itemCompleted);
            pnlMenu_top.Controls.Add(lbl_itemMyday);
            pnlMenu_top.Controls.Add(lbl_itemTasks);
            pnlMenu_top.Controls.Add(lbl_itemImportant);
            pnlMenu_top.Location = new Point(-1, -1);
            pnlMenu_top.Name = "pnlMenu_top";
            pnlMenu_top.Size = new Size(208, 336);
            pnlMenu_top.TabIndex = 0;
            // 
            // lbl_itemCompleted
            // 
            lbl_itemCompleted.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_itemCompleted.Image = Properties.Resources.completed_32;
            lbl_itemCompleted.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemCompleted.Location = new Point(-1, 268);
            lbl_itemCompleted.Name = "lbl_itemCompleted";
            lbl_itemCompleted.Padding = new Padding(10, 0, 15, 5);
            lbl_itemCompleted.Size = new Size(213, 50);
            lbl_itemCompleted.TabIndex = 3;
            lbl_itemCompleted.Text = "Completed ";
            lbl_itemCompleted.TextAlign = ContentAlignment.MiddleRight;
            lbl_itemCompleted.Click += lbl_itemCompleted_Click;
            lbl_itemCompleted.MouseEnter += lbl_itemCompleted_MouseEnter;
            lbl_itemCompleted.MouseLeave += lbl_itemCompleted_MouseLeave;
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
            lbl_itemImportant.Location = new Point(-1, 122);
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
            pnlMenu_center.Controls.Add(pnlitem_GroupName);
            pnlMenu_center.Controls.Add(lbl_itemNewGroup);
            pnlMenu_center.Location = new Point(-1, 341);
            pnlMenu_center.Name = "pnlMenu_center";
            pnlMenu_center.Size = new Size(208, 126);
            pnlMenu_center.TabIndex = 1;
            // 
            // pnlitem_GroupName
            // 
            pnlitem_GroupName.Controls.Add(txtItem_GroupName);
            pnlitem_GroupName.Controls.Add(lblitem_iconGroupName);
            pnlitem_GroupName.Location = new Point(0, 73);
            pnlitem_GroupName.Name = "pnlitem_GroupName";
            pnlitem_GroupName.Size = new Size(213, 50);
            pnlitem_GroupName.TabIndex = 4;
            // 
            // txtItem_GroupName
            // 
            txtItem_GroupName.Dock = DockStyle.Right;
            txtItem_GroupName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtItem_GroupName.Location = new Point(61, 0);
            txtItem_GroupName.Multiline = true;
            txtItem_GroupName.Name = "txtItem_GroupName";
            txtItem_GroupName.PlaceholderText = "Name of Group";
            txtItem_GroupName.Size = new Size(152, 50);
            txtItem_GroupName.TabIndex = 1;
            txtItem_GroupName.KeyDown += txtItem_GroupName_KeyDown;
            // 
            // lblitem_iconGroupName
            // 
            lblitem_iconGroupName.Image = Properties.Resources.list_24px;
            lblitem_iconGroupName.Location = new Point(0, 0);
            lblitem_iconGroupName.Name = "lblitem_iconGroupName";
            lblitem_iconGroupName.Size = new Size(62, 50);
            lblitem_iconGroupName.TabIndex = 0;
            // 
            // lbl_itemNewGroup
            // 
            lbl_itemNewGroup.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_itemNewGroup.ForeColor = Color.FromArgb(37, 100, 207);
            lbl_itemNewGroup.Image = (Image)resources.GetObject("lbl_itemNewGroup.Image");
            lbl_itemNewGroup.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_itemNewGroup.Location = new Point(-1, 0);
            lbl_itemNewGroup.Name = "lbl_itemNewGroup";
            lbl_itemNewGroup.Padding = new Padding(10, 0, 10, 2);
            lbl_itemNewGroup.Size = new Size(213, 50);
            lbl_itemNewGroup.TabIndex = 3;
            lbl_itemNewGroup.Text = "New Group";
            lbl_itemNewGroup.TextAlign = ContentAlignment.MiddleRight;
            lbl_itemNewGroup.Click += lbl_itemNewGroup_Click;
            lbl_itemNewGroup.MouseEnter += lbl_itemNewGroup_MouseEnter;
            lbl_itemNewGroup.MouseLeave += lbl_itemNewGroup_MouseLeave;
            // 
            // pnlMenu_bottom
            // 
            pnlMenu_bottom.AutoScroll = true;
            pnlMenu_bottom.Location = new Point(-1, 473);
            pnlMenu_bottom.Name = "pnlMenu_bottom";
            pnlMenu_bottom.Size = new Size(208, 349);
            pnlMenu_bottom.TabIndex = 2;
            // 
            // MenuTaskBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(208, 853);
            Controls.Add(pnlMenu_bottom);
            Controls.Add(pnlMenu_center);
            Controls.Add(pnlMenu_top);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MenuTaskBar";
            Text = "MenuTaskBar";
            pnlMenu_top.ResumeLayout(false);
            pnlMenu_center.ResumeLayout(false);
            pnlitem_GroupName.ResumeLayout(false);
            pnlitem_GroupName.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu_top;
        private System.Windows.Forms.Panel pnlMenu_center;
        private Label lbl_itemTasks;
        private Label lbl_itemImportant;
        private Label lbl_itemMyday;
        private Label lbl_itemNewGroup;
        private Label label2;
        private Label lbl_itemCompleted;
        private FlowLayoutPanel pnlMenu_bottom;
        private System.Windows.Forms.Panel pnlitem_GroupName;
        private TextBox txtItem_GroupName;
        private Label lblitem_iconGroupName;
    }
}