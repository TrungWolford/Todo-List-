using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserLoginBUS
    {
        public UserDTO userDTO = new UserDTO();
        public static readonly UserDAO userDAO = UserDAO.Instance;

        public bool checklogin(string username, string pwd_hash)
        {
            try
            {
                bool check = userDAO.CheckLogin(username, pwd_hash);
                return check;
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex); 
                return false;
            }
        }

    }
}
