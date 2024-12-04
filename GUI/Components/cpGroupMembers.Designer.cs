namespace GUI.Components
{
    partial class cpGroupMembers
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
            pnlGroupMembers = new System.Windows.Forms.Panel();
            lblRoleUser = new Label();
            lblUsername = new Label();
            pnlGroupMembers.SuspendLayout();
            SuspendLayout();
            // 
            // pnlGroupMembers
            // 
            pnlGroupMembers.Controls.Add(lblRoleUser);
            pnlGroupMembers.Controls.Add(lblUsername);
            pnlGroupMembers.Location = new Point(0, 0);
            pnlGroupMembers.Name = "pnlGroupMembers";
            pnlGroupMembers.Size = new Size(400, 50);
            pnlGroupMembers.TabIndex = 0;
            // 
            // lblRoleUser
            // 
            lblRoleUser.Dock = DockStyle.Right;
            lblRoleUser.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblRoleUser.Location = new Point(305, 0);
            lblRoleUser.Name = "lblRoleUser";
            lblRoleUser.Size = new Size(95, 50);
            lblRoleUser.TabIndex = 1;
            lblRoleUser.Text = "label1";
            lblRoleUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsername
            // 
            lblUsername.Dock = DockStyle.Left;
            lblUsername.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.Image = Properties.Resources.user_24px;
            lblUsername.ImageAlign = ContentAlignment.MiddleLeft;
            lblUsername.Location = new Point(0, 0);
            lblUsername.Name = "lblUsername";
            lblUsername.Padding = new Padding(20, 0, 0, 0);
            lblUsername.Size = new Size(299, 50);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "label1";
            lblUsername.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cpGroupMembers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pnlGroupMembers);
            Name = "cpGroupMembers";
            Size = new Size(400, 50);
            pnlGroupMembers.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlGroupMembers;
        private Label lblUsername;
        private Label lblRoleUser;
    }
}
