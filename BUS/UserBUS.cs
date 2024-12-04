using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserBUS
    {
        private List<UserDTO> users;
        private static readonly UserDAO userDAO = UserDAO.Instance;

        public UserBUS()
        {
            users = userDAO.GetAll();
        }

        public UserDTO selectUserByID(int userID)
        {
            try
            {
                UserDTO user = new UserDTO();
                user = userDAO.selectedByID(userID);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while finding user: " + ex.Message);
                return null;
            }
        }

        public UserDTO selectedUserByName(string userName)
        {
            try
            {
                UserDTO user = new UserDTO();
                user = userDAO.selectedByName(userName);
                if (user != null)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while finding user: " + ex.Message);
                return null;
            }
        }

        public bool findUserByUsername(string userName)
        {
            try
            {
                bool check = userDAO.SelectByID(userName) > 0;
                if (check)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while finding user: " + ex.Message);
                return false;
            }
        }
    }

}
