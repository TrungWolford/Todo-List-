using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace DAO
{
    public class TaskDAO : InterfaceDAO<TaskDTO>
    {
        private static TaskDAO instance;
        public static TaskDAO Instance
        {
            get { if (instance == null) instance = new TaskDAO(); return instance; }
            private set { instance = value; }
        }
        private TaskDAO() { }
        public void Insert(TaskDTO task)
        {
            string query = "INSERT INTO Task (Title, Description, DueDate, CreatedDate, IsImportant, IsDeleted, CompletedDate, CreatedBy) VALUES (@title, @description, @dueDate, @createdDate, @isImportant, @isDeleted, @completedDate, @createdBy)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = task.Title },
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = task.Description },
                new SqlParameter("@dueDate", SqlDbType.NVarChar) { Value = task.DueDate },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = task.CreatedDate },
                new SqlParameter("@isImportant", SqlDbType.Bit) { Value = task.IsImportant },
                new SqlParameter("@isDeleted", SqlDbType.Bit) { Value = task.IsDeleted },
                new SqlParameter("@completedDate", SqlDbType.DateTime) { Value = task.CompletedDate },
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = task.CreatedBy }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            int newId = Convert.ToInt32(result);

            task.TaskID = newId;
        }
        public void Update(TaskDTO task) 
        {
            string query = "UPDATE Task SET Title = @title, Description = @description, DueDate = @dueDate, CreatedDate = @createdDate, IsImportant = @isImportant , IsDeleted = @isDeleted , CompletedDate = @completedDate , CreatedBy = @createdBy WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@title", SqlDbType.NVarChar) { Value = task.Title },
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = task.Description },
                new SqlParameter("@dueDate", SqlDbType.NVarChar) { Value = task.DueDate },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = task.CreatedDate },
                new SqlParameter("@isImportant", SqlDbType.Bit) { Value = task.IsImportant },
                new SqlParameter("@isDeleted", SqlDbType.Bit) { Value = task.IsDeleted },
                new SqlParameter("@completedDate", SqlDbType.DateTime) { Value = task.CompletedDate },
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = task.CreatedBy },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = task.TaskID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Delete(TaskDTO task) 
        {
            string query = "DELETE FROM Task WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = task.TaskID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
