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
            label2 = new Label();
            label1 = new Label();
            lblMenu_myday = new Label();
            pnlMenu_center = new System.Windows.Forms.Panel();
            label3 = new Label();
            itemMenu1 = new ItemMenu("C:\\Users\\ACER\\Documents\\C#\\ToDoList\\GUI\\icon\\sunny.png", "My day");
            pnlMenu_top.SuspendLayout();
            pnlMenu_center.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMenu_top
            // 
            pnlMenu_top.Controls.Add(label2);
            pnlMenu_top.Controls.Add(label1);
            pnlMenu_top.Controls.Add(lblMenu_myday);
            pnlMenu_top.Location = new Point(-1, -1);
            pnlMenu_top.Name = "pnlMenu_top";
            pnlMenu_top.Size = new Size(208, 277);
            pnlMenu_top.TabIndex = 0;
            // 
            // label2
            // 
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(3, 194);
            label2.Name = "label2";
            label2.Padding = new Padding(11, 0, 60, 0);
            label2.Size = new Size(206, 45);
            label2.TabIndex = 2;
            label2.Text = "Tasks";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(2, 126);
            label1.Name = "label1";
            label1.Padding = new Padding(13, 0, 10, 0);
            label1.Size = new Size(206, 45);
            label1.TabIndex = 1;
            label1.Text = "Important";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblMenu_myday
            // 
            lblMenu_myday.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu_myday.Image = Properties.Resources.sunny;
            lblMenu_myday.ImageAlign = ContentAlignment.MiddleLeft;
            lblMenu_myday.Location = new Point(2, 58);
            lblMenu_myday.Name = "lblMenu_myday";
            lblMenu_myday.Padding = new Padding(11, 0, 40, 0);
            lblMenu_myday.Size = new Size(206, 45);
            lblMenu_myday.TabIndex = 0;
            lblMenu_myday.Text = "My day";
            lblMenu_myday.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pnlMenu_center
            // 
            pnlMenu_center.Controls.Add(itemMenu1);
            pnlMenu_center.Controls.Add(label3);
            pnlMenu_center.Location = new Point(-1, 282);
            pnlMenu_center.Name = "pnlMenu_center";
            pnlMenu_center.Size = new Size(208, 571);
            pnlMenu_center.TabIndex = 1;
            // 
            // label3
            // 
            label3.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(37, 100, 207);
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(2, 42);
            label3.Name = "label3";
            label3.Padding = new Padding(5, 0, 0, 0);
            label3.Size = new Size(207, 45);
            label3.TabIndex = 3;
            label3.Text = "New group";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // itemMenu1
            // 
            itemMenu1.Location = new Point(0, 150);
            itemMenu1.Name = "itemMenu1";
            itemMenu1.Size = new Size(208, 62);
            itemMenu1.TabIndex = 4;
            // 
            // MenuTaskBar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(207, 853);
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
        private Label lblMenu_myday;
        private Label label1;
        private Label label2;
        private Label label3;
        private ItemMenu itemMenu1;
    }
}