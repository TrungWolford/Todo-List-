using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Helper
{
    public class Validation
    {
        // Kiem tra chuoi trong
        public static bool isEmpty(string input)
        {
            return string.IsNullOrEmpty(input);
        }

        // Regex kiểm tra username có ít nhất 6 ký tự
        public static bool IsValidUsername(string username)
        {
            string usernamePattern = @"^[a-zA-Z0-9]{6,}$";
            return Regex.IsMatch(username, usernamePattern);
        }

        // Kiem tra email
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, emailPattern);
        }

        // Kiem tra mat khau co khop
        public static bool ArePasswordsEqual(string pass, string repass)
        {
            return pass == repass;
        }

        // Kiểm tra mật khẩu có ít nhất 6 ký tự và không chứa khoảng trắng
        public static bool IsValidPassword(string password)
        {   
            return password.Length >= 6 && !password.Contains(" ");
        }
    }


    // Ma hoa mat khau 
    public class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                StringBuilder hashString = new StringBuilder();

                foreach (byte b in hashBytes)
                {
                    hashString.Append(b.ToString("x2")); // Chuyển thành chuỗi hex
                }

                return hashString.ToString();
            }
        }
    }
}
