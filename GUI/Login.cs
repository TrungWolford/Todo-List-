using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using Helper;
using BUS;
using Microsoft.VisualBasic.ApplicationServices;
using DAO;

namespace GUI
{
    public partial class Login : Form
    {
        public UserLoginBUS userLoginBUS = new UserLoginBUS();
        public UserDTO userDTO = new UserDTO();

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        public bool CheckValidation()
        {
            bool isEmptyUserName = Validation.isEmpty(txt_username.Text.Trim());
            bool isPassEmpty = Validation.isEmpty(txt_password.Text.Trim());

            if (isEmptyUserName)
            {
                MessageBox.Show("Username must not empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (isPassEmpty)
            {
                MessageBox.Show("Password must not empty!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void lbl_btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckValidation())
                {
                    userDTO.UserName = txt_username.Text.Trim();
                    userDTO.Password = PasswordHasher.HashPassword(txt_password.Text.Trim());

                    bool test = userLoginBUS.checklogin(userDTO.UserName, userDTO.Password);
                    if (test)
                    {
                        MessageBox.Show("Welcome to my todolist!", "Information",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);

                        UserDTO user = UserDAO.Instance.selectedByName(userDTO.UserName);
                        
                        Main main = new Main(user);
                        main.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Username or password is wrong!", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void lbl_toRegisterFrame_Click(object sender, EventArgs e)
        {
            Register regisForm = new Register();
            regisForm.Show();
            this.Hide();
        }

        private void checkbox_showpwd_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.PasswordChar = checkbox_showpwd.Checked ? '\0' : '*';
        }
    }
}
