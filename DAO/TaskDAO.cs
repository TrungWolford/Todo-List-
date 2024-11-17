using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaskDAO : InterfaceDAO<TaskDTO>
    {
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
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Update(TaskDTO task) { }
        public void Delete(TaskDTO task) { }
    }
}
