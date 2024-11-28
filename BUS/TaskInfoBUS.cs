using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TaskInfoBUS
    {
        public List<TaskDTO> listTask;
        private static readonly TaskDAO taskDAO = TaskDAO.Instance;

        public TaskDTO getTitle(int taskID)
        {
            try
            {
                
                listTask = taskDAO.GetTitlesByTaskID(taskID);

                if (listTask.Count > 0)
                {
                    Console.WriteLine(listTask[0].ToString());  // Sửa index từ 1 thành 0 vì index bắt đầu từ 0
                    return listTask[0];  // Trả về task đầu tiên
                }
                else
                {
                    // Nếu không có dữ liệu
                    Console.WriteLine("No task found with the given TaskID.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return null;
            }
        }


    }
}
