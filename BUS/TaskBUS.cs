using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaskBUS
    {

        public List<TaskDTO> listTasks;
        private static readonly TaskDAO taskDAO = TaskDAO.Instance;

        public TaskBUS()
        {
            listTasks = taskDAO.GetAll();
        }

        public List<TaskDTO> GetAll()
        {
            return taskDAO.GetAll();
        }

        public bool insert(TaskDTO taskDTO)
        {
            
            try
            {
                bool check = taskDAO.Insert(taskDTO) != 0;
                if (check)
                {
                    this.listTasks.Add(taskDTO);
                }

                return check;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error while inserting task: " + ex.Message);
                return false;
            }
        }
    }
}
