using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class sortBUS
    {
        public List<TaskDTO> listTasks;
        public List<UserDTO> listUsers;
        private static readonly TaskDAO taskDAO = TaskDAO.Instance;
        private static readonly UserDAO userDAO = UserDAO.Instance;

        public List<UserDTO> getUserByUsername(string username)
        {
            return userDAO.selectByUsername(username);
        }

        public List<TaskDTO> getAllTask(int id)
        {
            return taskDAO.selectedByID(id);
        }

    }
}
