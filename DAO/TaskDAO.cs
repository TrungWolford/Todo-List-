using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            string query = "INSERT INTO Task (Title, Description, DueDate, CreatedDate, IsImportant, IsDeleted, CompletedDate, CreatedBy, GroupID) VALUES (@title, @description, @dueDate, @createdDate, @isImportant, @isDeleted, @completedDate, @createdBy, @groupID); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {

                new SqlParameter("@title", SqlDbType.NVarChar) { Value = task.Title },
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = task.Description ?? (object)DBNull.Value},
                new SqlParameter("@dueDate", SqlDbType.NVarChar) { Value = task.DueDate },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = task.CreatedDate },
                new SqlParameter("@isImportant", SqlDbType.Bit) { Value = task.IsImportant },
                new SqlParameter("@isDeleted", SqlDbType.Bit) { Value = task.IsDeleted },
                new SqlParameter("@completedDate", SqlDbType.DateTime) { Value = task.CompletedDate ?? (object)DBNull.Value},
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = task.CreatedBy },
                new SqlParameter("@groupID", SqlDbType.Int) { Value = task.GroupID ?? (object)DBNull.Value}
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
                new SqlParameter("@description", SqlDbType.NVarChar) { Value = task.Description ?? (object)DBNull.Value},
                new SqlParameter("@dueDate", SqlDbType.NVarChar) { Value = task.DueDate },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = task.CreatedDate },
                new SqlParameter("@isImportant", SqlDbType.Bit) { Value = task.IsImportant },
                new SqlParameter("@isDeleted", SqlDbType.Bit) { Value = task.IsDeleted },
                new SqlParameter("@completedDate", SqlDbType.DateTime) { Value = task.CompletedDate ?? (object)DBNull.Value},
                new SqlParameter("@createdBy", SqlDbType.Int) { Value = task.CreatedBy },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = task.TaskID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return 0;
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

        public TaskDTO SelectByTaskID(int taskID)
        {
            string query = "SELECT * FROM [Task] WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", taskID)
            };

            // Tạo một đối tượng TaskDTO để lưu thông tin
            TaskDTO task = null;

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                if (reader.Read())
                {
                    // Đọc dữ liệu từ hàng kết quả và gán vào TaskDTO
                    task = new TaskDTO
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
                }
            }
            return task;
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
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        GroupID = reader.IsDBNull(reader.GetOrdinal("GroupID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GroupID"))
                    };
                    listTask.Add(task);
                }
            }

            return listTask;
        }

        public List<TaskDTO> selectedByID(int userID)
        {
            List<TaskDTO> listTaskByID = new List<TaskDTO>();
            string query = "SELECT * FROM Task WHERE CreatedBy = @UserID AND CompletedDate IS NULL";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
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
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        GroupID = reader.IsDBNull(reader.GetOrdinal("GroupID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GroupID"))
                    };
                    listTaskByID.Add(task);
                }
            }

            return listTaskByID;
        }

        public List<TaskDTO> selecteTaskCurrentDate(int userID)
        {
            List<TaskDTO> listTaskCurrentDate = new List<TaskDTO>();

            // CAST(DueDate AS DATE): Chuyển đổi cột DueDate thành kiểu DATE(chỉ lấy phần ngày, bỏ phần giờ).
            // CAST(GETDATE() AS DATE): Lấy ngày hiện tại của hệ thống(chỉ lấy phần ngày, bỏ phần giờ).
            string query = "SELECT * FROM Task WHERE CAST(DueDate AS DATE) = CAST(GETDATE() AS DATE) AND CreatedBy = @UserID AND CompletedDate IS NULL";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };
            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
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
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        GroupID = reader.IsDBNull(reader.GetOrdinal("GroupID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GroupID"))
                    };
                    listTaskCurrentDate.Add(task);
                }
            }

            return listTaskCurrentDate;
        }

        public List<TaskDTO> selecteAllTaskImportant(int userID)
        {
            List<TaskDTO> listTaskImportant = new List<TaskDTO>();
            string query = "SELECT * FROM Task WHERE IsImportant = 1 AND CreatedBy = @UserID AND CompletedDate IS NULL";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };
            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
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
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        GroupID = reader.IsDBNull(reader.GetOrdinal("GroupID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GroupID"))
                    };
                    listTaskImportant.Add(task);
                }
            }

            return listTaskImportant;
        }

        TaskDTO InterfaceDAO<TaskDTO>.selectedByID(int t)

        {
            throw new NotImplementedException();
        }

        public List<TaskDTO> GetTitlesByTaskID(int taskID)
        {
            string query = "SELECT Title FROM Task WHERE TaskID=@taskID";

            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", taskID)
            };

            List<TaskDTO> listTask = new List<TaskDTO>();

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
            {
                while (reader.Read())
                {
                    TaskDTO task = new TaskDTO
                    {
                        Title = reader.GetString(reader.GetOrdinal("Title"))
                    };
                    listTask.Add(task);
                }
            }

            return listTask;
        }

        public List<TaskDTO> selecteAllTaskCompleted(int userID)
        {
            List<TaskDTO> listTaskImportant = new List<TaskDTO>();
            string query = "SELECT * FROM Task WHERE CreatedBy = @UserID AND CompletedDate IS NOT NULL";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@UserID", userID)
            };
            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
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
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        GroupID = reader.IsDBNull(reader.GetOrdinal("GroupID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GroupID"))
                    };
                    listTaskImportant.Add(task);
                }
            }

            return listTaskImportant;
        }

        public List<TaskDTO> selectedAllTaskByGroupID(int userID, int groupID)
        {
            List<TaskDTO> listTasks = new List<TaskDTO>();
            string query = @"
                            SELECT * FROM Task t
                            LEFT JOIN [Group] g ON g.GroupID = t.GroupID
                       
                            WHERE g.GroupID = @groupID AND CompletedDate IS NULL";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                //new SqlParameter("@UserID", userID),
                new SqlParameter("@groupID", groupID)
            };

            using (SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters))
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
                        CreatedBy = reader.GetInt32(reader.GetOrdinal("CreatedBy")),
                        GroupID = reader.IsDBNull(reader.GetOrdinal("GroupID")) ? (int?)null : reader.GetInt32(reader.GetOrdinal("GroupID"))
                    };
                    listTasks.Add(task);
                }
            }

            return listTasks;
        }
    }
}
