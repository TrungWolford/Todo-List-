namespace GUI.Components
{
    partial class NewGroup
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
            pnlItemGroup = new System.Windows.Forms.Panel();
            lblItemGroup = new Label();
            pnlItemGroup.SuspendLayout();
            SuspendLayout();
            // 
            // pnlItemGroup
            // 
            pnlItemGroup.Controls.Add(lblItemGroup);
            pnlItemGroup.Location = new Point(0, 0);
            pnlItemGroup.Name = "pnlItemGroup";
            pnlItemGroup.Size = new Size(213, 50);
            pnlItemGroup.TabIndex = 0;
            // 
            // lblItemGroup
            // 
            lblItemGroup.Dock = DockStyle.Fill;
            lblItemGroup.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblItemGroup.Image = Properties.Resources.list_32px;
            lblItemGroup.ImageAlign = ContentAlignment.MiddleLeft;
            lblItemGroup.Location = new Point(0, 0);
            lblItemGroup.Name = "lblItemGroup";
            lblItemGroup.Padding = new Padding(10, 0, 15, 5);
            lblItemGroup.Size = new Size(213, 50);
            lblItemGroup.TabIndex = 0;
            lblItemGroup.Text = "label1";
            lblItemGroup.TextAlign = ContentAlignment.MiddleCenter;
            lblItemGroup.Click += lblItemGroup_Click;
            lblItemGroup.MouseEnter += lblItemGroup_MouseEnter;
            lblItemGroup.MouseLeave += lblItemGroup_MouseLeave;
            // 
            // NewGroup
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlItemGroup);
            Name = "NewGroup";
            Size = new Size(213, 50);
            pnlItemGroup.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlItemGroup;
        private Label lblItemGroup;
    }
}
