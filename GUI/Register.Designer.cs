namespace GUI
{
    partial class Register
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1Reg = new Label();
            lbl_titleReg = new Label();
            lbl_register = new Label();
            panel2 = new Label();
            lbl_btnLoginReg = new Label();
            lbl_toLoginFrame = new Label();
            lbl_askingReg = new Label();
            txt_repasswordReg = new TextBox();
            txt_passwordReg = new TextBox();
            txt_emailReg = new TextBox();
            lbl_repasswordReg = new Label();
            lbl_emailReg = new Label();
            lbl_passwordReg = new Label();
            txt_usernameReg = new TextBox();
            lbl_usernameReg = new Label();
            lbl_sologanReg = new Label();
            panel1Reg.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1Reg
            // 
            panel1Reg.BackColor = Color.FromArgb(37, 100, 207);
            panel1Reg.Controls.Add(lbl_titleReg);
            panel1Reg.Location = new Point(1, 1);
            panel1Reg.Name = "panel1Reg";
            panel1Reg.Size = new Size(700, 75);
            panel1Reg.TabIndex = 0;
            // 
            // lbl_titleReg
            // 
            lbl_titleReg.AutoSize = true;
            lbl_titleReg.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titleReg.ForeColor = Color.White;
            lbl_titleReg.Location = new Point(206, 8);
            lbl_titleReg.Name = "lbl_titleReg";
            lbl_titleReg.Size = new Size(276, 60);
            lbl_titleReg.TabIndex = 0;
            lbl_titleReg.Text = "CS Todo List";
            lbl_titleReg.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_register
            // 
            lbl_register.AutoSize = true;
            lbl_register.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_register.Location = new Point(274, 1);
            lbl_register.Name = "lbl_register";
            lbl_register.Size = new Size(134, 41);
            lbl_register.TabIndex = 1;
            lbl_register.Text = "Register";
            lbl_register.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbl_btnLoginReg);
            panel2.Controls.Add(lbl_toLoginFrame);
            panel2.Controls.Add(lbl_askingReg);
            panel2.Controls.Add(txt_repasswordReg);
            panel2.Controls.Add(txt_passwordReg);
            panel2.Controls.Add(txt_emailReg);
            panel2.Controls.Add(lbl_repasswordReg);
            panel2.Controls.Add(lbl_emailReg);
            panel2.Controls.Add(lbl_passwordReg);
            panel2.Controls.Add(txt_usernameReg);
            panel2.Controls.Add(lbl_usernameReg);
            panel2.Controls.Add(lbl_sologanReg);
            panel2.Controls.Add(lbl_register);
            panel2.Location = new Point(1, 78);
            panel2.Name = "panel2";
            panel2.Size = new Size(700, 575);
            panel2.TabIndex = 1;
            // 
            // lbl_btnLoginReg
            // 
            lbl_btnLoginReg.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_btnLoginReg.BackColor = Color.FromArgb(37, 100, 207);
            lbl_btnLoginReg.Cursor = Cursors.Hand;
            lbl_btnLoginReg.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_btnLoginReg.ForeColor = Color.White;
            lbl_btnLoginReg.Location = new Point(80, 432);
            lbl_btnLoginReg.Name = "lbl_btnLoginReg";
            lbl_btnLoginReg.Size = new Size(520, 30);
            lbl_btnLoginReg.TabIndex = 0;
            lbl_btnLoginReg.Text = "Submit";
            lbl_btnLoginReg.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbl_toLoginFrame
            // 
            lbl_toLoginFrame.AutoSize = true;
            lbl_toLoginFrame.Cursor = Cursors.Hand;
            lbl_toLoginFrame.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lbl_toLoginFrame.ForeColor = Color.FromArgb(37, 100, 207);
            lbl_toLoginFrame.Location = new Point(383, 478);
            lbl_toLoginFrame.Name = "lbl_toLoginFrame";
            lbl_toLoginFrame.Size = new Size(44, 20);
            lbl_toLoginFrame.TabIndex = 14;
            lbl_toLoginFrame.Text = "Login";
            // 
            // lbl_askingReg
            // 
            lbl_askingReg.AutoSize = true;
            lbl_askingReg.Location = new Point(174, 478);
            lbl_askingReg.Name = "lbl_askingReg";
            lbl_askingReg.Size = new Size(203, 20);
            lbl_askingReg.TabIndex = 13;
            lbl_askingReg.Text = "Have an account? Login now!";
            // 
            // txt_repasswordReg
            // 
            txt_repasswordReg.Location = new Point(288, 381);
            txt_repasswordReg.Name = "txt_repasswordReg";
            txt_repasswordReg.PasswordChar = '*';
            txt_repasswordReg.Size = new Size(300, 27);
            txt_repasswordReg.TabIndex = 10;
            // 
            // txt_passwordReg
            // 
            txt_passwordReg.Location = new Point(288, 297);
            txt_passwordReg.Name = "txt_passwordReg";
            txt_passwordReg.PasswordChar = '*';
            txt_passwordReg.Size = new Size(300, 27);
            txt_passwordReg.TabIndex = 9;
            // 
            // txt_emailReg
            // 
            txt_emailReg.Location = new Point(288, 216);
            txt_emailReg.Name = "txt_emailReg";
            txt_emailReg.Size = new Size(300, 27);
            txt_emailReg.TabIndex = 8;
            // 
            // lbl_repasswordReg
            // 
            lbl_repasswordReg.AutoSize = true;
            lbl_repasswordReg.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_repasswordReg.Location = new Point(96, 370);
            lbl_repasswordReg.Name = "lbl_repasswordReg";
            lbl_repasswordReg.Size = new Size(180, 38);
            lbl_repasswordReg.TabIndex = 7;
            lbl_repasswordReg.Text = "Re-Password:";
            // 
            // lbl_emailReg
            // 
            lbl_emailReg.AutoSize = true;
            lbl_emailReg.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_emailReg.Location = new Point(96, 205);
            lbl_emailReg.Name = "lbl_emailReg";
            lbl_emailReg.Size = new Size(89, 38);
            lbl_emailReg.TabIndex = 6;
            lbl_emailReg.Text = "Email:";
            // 
            // lbl_passwordReg
            // 
            lbl_passwordReg.AutoSize = true;
            lbl_passwordReg.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_passwordReg.Location = new Point(96, 286);
            lbl_passwordReg.Name = "lbl_passwordReg";
            lbl_passwordReg.Size = new Size(138, 38);
            lbl_passwordReg.TabIndex = 5;
            lbl_passwordReg.Text = "Password:";
            // 
            // txt_usernameReg
            // 
            txt_usernameReg.Location = new Point(288, 137);
            txt_usernameReg.Name = "txt_usernameReg";
            txt_usernameReg.Size = new Size(300, 27);
            txt_usernameReg.TabIndex = 4;
            // 
            // lbl_usernameReg
            // 
            lbl_usernameReg.AutoSize = true;
            lbl_usernameReg.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_usernameReg.Location = new Point(96, 126);
            lbl_usernameReg.Name = "lbl_usernameReg";
            lbl_usernameReg.Size = new Size(148, 38);
            lbl_usernameReg.TabIndex = 3;
            lbl_usernameReg.Text = "Username:";
            // 
            // lbl_sologanReg
            // 
            lbl_sologanReg.AutoSize = true;
            lbl_sologanReg.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_sologanReg.Location = new Point(162, 42);
            lbl_sologanReg.Name = "lbl_sologanReg";
            lbl_sologanReg.Size = new Size(360, 28);
            lbl_sologanReg.TabIndex = 2;
            lbl_sologanReg.Text = "Todo gives you focus, from work to play";
            lbl_sologanReg.TextAlign = ContentAlignment.TopCenter;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 603);
            Controls.Add(panel2);
            Controls.Add(panel1Reg);
            Name = "Register";
            Text = "CS Todo List";
            panel1Reg.ResumeLayout(false);
            panel1Reg.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label panel1Reg;
        private Label lbl_titleReg;
        private Label lbl_register;
        private Label panel2;
        private Label lbl_sologanReg;
        private Label lbl_repasswordReg;
        private Label lbl_emailReg;
        private Label lbl_passwordReg;
        private TextBox txt_usernameReg;
        private Label lbl_usernameReg;
        private TextBox txt_emailReg;
        private TextBox txt_repasswordReg;
        private TextBox txt_passwordReg;
        private Label lbl_btnLoginReg;
        private Label lbl_toLoginFrame;
        private Label lbl_askingReg;
    }
}
