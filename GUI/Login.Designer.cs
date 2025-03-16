namespace GUI
{
    partial class Login
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
            panel1 = new Label();
            lbl_title = new Label();
            lbl_login = new Label();
            lbl_sologan = new Label();
            lbl_username = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            lbl_password = new Label();
            lbl_btnLogin = new Label();
            lbl_asking = new Label();
            lbl_toRegisterFrame = new Label();
            checkbox_showpwd = new CheckBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 100, 207);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 75);
            panel1.TabIndex = 1;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.BackColor = Color.FromArgb(37, 100, 207);
            lbl_title.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_title.ForeColor = Color.White;
            lbl_title.Location = new Point(258, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(153, 60);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "AI-DO";
            lbl_title.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_login
            // 
            lbl_login.AutoSize = true;
            lbl_login.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_login.Location = new Point(280, 101);
            lbl_login.Name = "lbl_login";
            lbl_login.Size = new Size(97, 41);
            lbl_login.TabIndex = 2;
            lbl_login.Text = "Login";
            lbl_login.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_sologan
            // 
            lbl_sologan.AutoSize = true;
            lbl_sologan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sologan.Location = new Point(159, 142);
            lbl_sologan.Name = "lbl_sologan";
            lbl_sologan.Size = new Size(360, 28);
            lbl_sologan.TabIndex = 3;
            lbl_sologan.Text = "Todo gives you focus, from work to play";
            lbl_sologan.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_username
            // 
            lbl_username.AutoSize = true;
            lbl_username.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_username.Location = new Point(95, 221);
            lbl_username.Name = "lbl_username";
            lbl_username.Size = new Size(148, 38);
            lbl_username.TabIndex = 4;
            lbl_username.Text = "Username:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(280, 232);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(300, 27);
            txt_username.TabIndex = 5;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(280, 323);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new Size(300, 27);
            txt_password.TabIndex = 10;
            // 
            // lbl_password
            // 
            lbl_password.AutoSize = true;
            lbl_password.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_password.Location = new Point(105, 312);
            lbl_password.Name = "lbl_password";
            lbl_password.Size = new Size(138, 38);
            lbl_password.TabIndex = 11;
            lbl_password.Text = "Password:";
            // 
            // lbl_btnLogin
            // 
            lbl_btnLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_btnLogin.BackColor = Color.FromArgb(37, 100, 207);
            lbl_btnLogin.Cursor = Cursors.Hand;
            lbl_btnLogin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_btnLogin.ForeColor = Color.White;
            lbl_btnLogin.Location = new Point(78, 428);
            lbl_btnLogin.Name = "lbl_btnLogin";
            lbl_btnLogin.Size = new Size(520, 37);
            lbl_btnLogin.TabIndex = 12;
            lbl_btnLogin.Text = "Login";
            lbl_btnLogin.TextAlign = ContentAlignment.TopCenter;
            lbl_btnLogin.Click += lbl_btnLogin_Click;
            // 
            // lbl_asking
            // 
            lbl_asking.AutoSize = true;
            lbl_asking.Location = new Point(159, 486);
            lbl_asking.Name = "lbl_asking";
            lbl_asking.Size = new Size(243, 20);
            lbl_asking.TabIndex = 14;
            lbl_asking.Text = "Don't have an account? Create one!";
            // 
            // lbl_toRegisterFrame
            // 
            lbl_toRegisterFrame.AutoSize = true;
            lbl_toRegisterFrame.Cursor = Cursors.Hand;
            lbl_toRegisterFrame.Font = new Font("Segoe UI", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_toRegisterFrame.ForeColor = Color.FromArgb(37, 100, 207);
            lbl_toRegisterFrame.Location = new Point(417, 479);
            lbl_toRegisterFrame.Name = "lbl_toRegisterFrame";
            lbl_toRegisterFrame.Size = new Size(81, 28);
            lbl_toRegisterFrame.TabIndex = 15;
            lbl_toRegisterFrame.Text = "Register";
            lbl_toRegisterFrame.Click += lbl_toRegisterFrame_Click;
            // 
            // checkbox_showpwd
            // 
            checkbox_showpwd.AutoSize = true;
            checkbox_showpwd.Location = new Point(446, 371);
            checkbox_showpwd.Name = "checkbox_showpwd";
            checkbox_showpwd.Size = new Size(134, 24);
            checkbox_showpwd.TabIndex = 16;
            checkbox_showpwd.Text = "Show password";
            checkbox_showpwd.UseVisualStyleBackColor = true;
            checkbox_showpwd.CheckedChanged += checkbox_showpwd_CheckedChanged;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 603);
            Controls.Add(lbl_title);
            Controls.Add(checkbox_showpwd);
            Controls.Add(lbl_toRegisterFrame);
            Controls.Add(lbl_asking);
            Controls.Add(lbl_btnLogin);
            Controls.Add(lbl_password);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(lbl_username);
            Controls.Add(lbl_sologan);
            Controls.Add(lbl_login);
            Controls.Add(panel1);
            Name = "Login";
            Text = "CS Todo List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label panel1;
        private Label lbl_title;
        private Label lbl_login;
        private Label lbl_sologan;
        private Label lbl_username;
        private TextBox txt_username;
        private TextBox txt_password;
        private Label lbl_password;
        private Label lbl_btnLogin;
        private Label lbl_asking;
        private Label lbl_toRegisterFrame;
        private CheckBox checkbox_showpwd;
    }
}