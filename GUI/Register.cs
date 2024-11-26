using DTO;
using Helper;
using BUS;

namespace GUI;

public partial class Register : Form
{
    private UserDTO userDTO = new UserDTO();
    private UserRegisterBUS userRegBUS = new UserRegisterBUS();

    public Register()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
    }

    // Kiem tra hop le
    private bool checkValidation()
    {
        bool isEmptyUserName = Validation.isEmpty(txt_usernameReg.Text);

        bool isUserNameExist = userRegBUS.selectbyid(txt_usernameReg.Text.Trim()) > 0;

        bool isEmptyEmail = Validation.isEmpty(txt_emailReg.Text);

        bool isEmptyPass = Validation.isEmpty(txt_passwordReg.Text);

        bool isEmptyRepass = Validation.isEmpty(txt_repasswordReg.Text);

        bool testUserName = Validation.IsValidUsername(txt_usernameReg.Text);

        bool testEmail = Validation.IsValidEmail(txt_emailReg.Text);

        bool testPasswordEqual = Validation.ArePasswordsEqual(txt_passwordReg.Text, txt_repasswordReg.Text);

        bool testPassword = Validation.IsValidPassword(txt_passwordReg.Text);

        if (isEmptyUserName)
        {
            MessageBox.Show("UserName must not empty!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (isEmptyEmail)
        {
            MessageBox.Show("Email must not empty!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (isEmptyPass)
        {
            MessageBox.Show("Password must not empty!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (isEmptyRepass)
        {
            MessageBox.Show("Repassword must not empty!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (!testUserName)
        {
            MessageBox.Show("Username must have at least 6 characters and cannot contain special characters!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (isUserNameExist)
        {
            MessageBox.Show("Username is already exist!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (!testEmail)
        {
            MessageBox.Show("Email is not validated!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (!testPasswordEqual)
        {
            MessageBox.Show("Password and Repassword are not fixed!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
        else if (!testPassword)
        {
            MessageBox.Show("Password must greater than 6 characters!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        return true;
    }

    // xu kien bam btn Submit
    private void lbl_btnLoginReg_Click(object sender, EventArgs e)
    {
        try
        {

            bool checkValid = checkValidation();
            DateTime today = DateTime.Now;
            if (checkValid)
            {              
                userDTO.UserName    = txt_usernameReg.Text.Trim();
                userDTO.Email       = txt_emailReg.Text.Trim();
                userDTO.Password    = PasswordHasher.HashPassword(txt_passwordReg.Text.Trim());
                userDTO.CreatedDate = today;

                bool test = userRegBUS.insert(userDTO) > 0;

                if (test)
                {
                    MessageBox.Show("Registered successfully", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login loginForm = new Login();
                    loginForm.Show();
                    this.Hide();
                }
                else
                {
                    Console.WriteLine(userDTO);
                }
            } 
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex);
        }
    }

    private void lbl_toLoginFrame_Click(object sender, EventArgs e)
    {
        Login loginForm = new Login();
        loginForm.Show();
        this.Hide();
    }
}
