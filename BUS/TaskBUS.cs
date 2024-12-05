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

        public List<TaskDTO> getAllTaskCompleted(int id)
        {
            return taskDAO.selecteAllTaskCompleted(id);
        }

        public List<TaskDTO> getAllByUserID(int id)
        {
            return taskDAO.selectedByID(id);
        }

        public List<TaskDTO> getAllTaskCurrentDate(int id)
        {
            return taskDAO.selecteTaskCurrentDate(id);
        }

        public List<TaskDTO> getAllTaskImportant(int id)
        {
            return taskDAO.selecteAllTaskImportant(id);
        }

        public List<TaskDTO> getAllTaskByGroupID(int groupID)
        {
            return taskDAO.selectedAllTaskByGroupID(groupID);
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

        public bool update(TaskDTO taskDTO)
        {
            try
            {
                bool check = taskDAO.Update(taskDTO) != 0;
                TaskDTO existingTask = null;

                if (check)
                {
                    foreach (var task in listTasks)
                    {
                        if (task.TaskID == taskDTO.TaskID)
                        {
                            existingTask = task;
                            break; 
                        }
                    }

                    if (existingTask != null)
                    {
                        taskDTO.Title = existingTask.Title;
                        taskDTO.Description = existingTask.Description;
                        taskDTO.DueDate = existingTask.DueDate;
                        taskDTO.CreatedDate = existingTask.CreatedDate;
                        taskDTO.IsImportant = existingTask.IsImportant;
                        taskDTO.IsDeleted = existingTask.IsDeleted;
                        taskDTO.CompletedDate = existingTask.CompletedDate;
                    }
                    else
                    {
                        return false;
                    }
                }
                return check;
            } catch (Exception ex)
            {
                Console.WriteLine("Error while updating task: " + ex.Message);
                return false;
            }
        }
    }
}
