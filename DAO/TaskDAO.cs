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
        public int Insert(TaskDTO task)
        {
            // sua TaskID
            string query = "INSERT INTO Task (Title, Description, DueDate, CreatedDate, IsImportant, IsDeleted, CompletedDate, CreatedBy) VALUES (@title, @description, @dueDate, @createdDate, @isImportant, @isDeleted, @completedDate, @createdBy); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {

                new SqlParameter("@title", SqlDbType.NVarChar) { Value = task.Title },
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = task.Description ?? (object)DBNull.Value},
                new SqlParameter("@dueDate", SqlDbType.NVarChar) { Value = task.DueDate },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = task.CreatedDate },
                new SqlParameter("@isImportant", SqlDbType.Bit) { Value = task.IsImportant },
                new SqlParameter("@isDeleted", SqlDbType.Bit) { Value = task.IsDeleted },
                new SqlParameter("@completedDate", SqlDbType.DateTime) { Value = task.CompletedDate ?? (object)DBNull.Value},
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = task.CreatedBy }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                task.TaskID = newId;
                return newId;
            }
            return 0;
        }
        public int Update(TaskDTO task) 
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
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; 
        }
        public int Delete(TaskDTO task) 
        {
            string query = "DELETE FROM Task WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = task.TaskID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; 
        }

        public List<TaskDTO> GetAll()
        {
            List<TaskDTO> listTask = new List<TaskDTO>();
            string query = "SELECT * FROM Task";

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, null)) // 'using' với reader nhưng không đóng kết nối
            {
                while (reader.Read())
                {
                    TaskDTO task = new TaskDTO
                    {
                        TaskID = reader.GetInt32(reader.GetOrdinal("TaskID")),
                        Title = reader.GetString(reader.GetOrdinal("Title")),
                        Description = reader.IsDBNull(reader.GetOrdinal("Description")) ? null : reader.GetString(reader.GetOrdinal("Description")),
                        DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
                        CreatedDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate")),
                        IsImportant = reader.GetBoolean(reader.GetOrdinal("IsImportant")),
                        IsDeleted = reader.GetBoolean(reader.GetOrdinal("IsDeleted")),
                        CompletedDate = reader.IsDBNull(reader.GetOrdinal("CompletedDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("CompletedDate")),
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy"))
                    };
                    listTask.Add(task);
                }
            }

            return listTask;
        }
    }
}
