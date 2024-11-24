using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class UserRegisterBUS
    {
        //public List<UserDTO> listUsers;
        private readonly UserDAO userDAO = UserDAO.Instance; 

        public int insert(UserDTO user)
        {
            try
            {
                int rowsaffected = userDAO.Insert(user);
                return rowsaffected;
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return -1;
            }           
        }

        public int selectbyid(string username)
        {
            try
            {
                int rowsaffected = userDAO.SelectByID(username);
                return rowsaffected;
            } catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
                return -1;
            }           
        }
    }
}
