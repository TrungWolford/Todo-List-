namespace GUI.Panel
{
    partial class Member
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
            pnlCenter_member = new FlowLayoutPanel();
            pnlMember_owner = new System.Windows.Forms.Panel();
            lblTop_memberTitle = new Label();
            pnlBottom_member = new System.Windows.Forms.Panel();
            btnInvite_member = new Button();
            txtUsername_invite = new TextBox();
            lblUsername_invite = new Label();
            lblinvite_member = new Label();
            lblExit_member = new Label();
            pnlCenter_member.SuspendLayout();
            pnlBottom_member.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCenter_member
            // 
            pnlCenter_member.AutoScroll = true;
            pnlCenter_member.BackColor = Color.White;
            pnlCenter_member.Controls.Add(pnlMember_owner);
            pnlCenter_member.Location = new Point(0, 51);
            pnlCenter_member.Name = "pnlCenter_member";
            pnlCenter_member.Size = new Size(401, 252);
            pnlCenter_member.TabIndex = 0;
            // 
            // pnlMember_owner
            // 
            pnlMember_owner.Location = new Point(3, 3);
            pnlMember_owner.Name = "pnlMember_owner";
            pnlMember_owner.Size = new Size(398, 50);
            pnlMember_owner.TabIndex = 0;
            // 
            // lblTop_memberTitle
            // 
            lblTop_memberTitle.BackColor = Color.White;
            lblTop_memberTitle.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTop_memberTitle.Location = new Point(0, -2);
            lblTop_memberTitle.Name = "lblTop_memberTitle";
            lblTop_memberTitle.Size = new Size(401, 50);
            lblTop_memberTitle.TabIndex = 1;
            lblTop_memberTitle.Text = "Members on the group";
            lblTop_memberTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBottom_member
            // 
            pnlBottom_member.BackColor = Color.White;
            pnlBottom_member.Controls.Add(btnInvite_member);
            pnlBottom_member.Controls.Add(txtUsername_invite);
            pnlBottom_member.Controls.Add(lblUsername_invite);
            pnlBottom_member.Controls.Add(lblinvite_member);
            pnlBottom_member.Location = new Point(0, 309);
            pnlBottom_member.Name = "pnlBottom_member";
            pnlBottom_member.Size = new Size(401, 237);
            pnlBottom_member.TabIndex = 2;
            // 
            // btnInvite_member
            // 
            btnInvite_member.Location = new Point(39, 143);
            btnInvite_member.Name = "btnInvite_member";
            btnInvite_member.Size = new Size(320, 29);
            btnInvite_member.TabIndex = 3;
            btnInvite_member.Text = "Invite";
            btnInvite_member.UseVisualStyleBackColor = true;
            btnInvite_member.Click += btnInvite_member_Click;
            // 
            // txtUsername_invite
            // 
            txtUsername_invite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername_invite.Location = new Point(209, 75);
            txtUsername_invite.Name = "txtUsername_invite";
            txtUsername_invite.Size = new Size(179, 34);
            txtUsername_invite.TabIndex = 2;
            // 
            // lblUsername_invite
            // 
            lblUsername_invite.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername_invite.Location = new Point(12, 75);
            lblUsername_invite.Name = "lblUsername_invite";
            lblUsername_invite.Size = new Size(203, 42);
            lblUsername_invite.TabIndex = 1;
            lblUsername_invite.Text = "Member's UserName:";
            // 
            // lblinvite_member
            // 
            lblinvite_member.BackColor = Color.White;
            lblinvite_member.Dock = DockStyle.Top;
            lblinvite_member.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblinvite_member.Location = new Point(0, 0);
            lblinvite_member.Name = "lblinvite_member";
            lblinvite_member.Size = new Size(401, 50);
            lblinvite_member.TabIndex = 0;
            lblinvite_member.Text = "Invite Members";
            lblinvite_member.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblExit_member
            // 
            lblExit_member.BackColor = Color.White;
            lblExit_member.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExit_member.ForeColor = Color.DarkRed;
            lblExit_member.Location = new Point(0, 549);
            lblExit_member.Name = "lblExit_member";
            lblExit_member.Size = new Size(401, 50);
            lblExit_member.TabIndex = 3;
            lblExit_member.Text = "Leave this group";
            lblExit_member.TextAlign = ContentAlignment.MiddleCenter;
            lblExit_member.Click += lblExit_member_Click;
            lblExit_member.MouseEnter += lblExit_member_MouseEnter;
            lblExit_member.MouseLeave += lblExit_member_MouseLeave;
            // 
            // Member
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 600);
            Controls.Add(lblExit_member);
            Controls.Add(pnlBottom_member);
            Controls.Add(lblTop_memberTitle);
            Controls.Add(pnlCenter_member);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Member";
            Text = "Member";
            pnlCenter_member.ResumeLayout(false);
            pnlBottom_member.ResumeLayout(false);
            pnlBottom_member.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel pnlCenter_member;
        private Label lblTop_memberTitle;
        private System.Windows.Forms.Panel pnlBottom_member;
        private Label lblinvite_member;
        private Label lblExit_member;
        private TextBox txtUsername_invite;
        private Label lblUsername_invite;
        private Button btnInvite_member;
        private System.Windows.Forms.Panel pnlMember_owner;
    }
}