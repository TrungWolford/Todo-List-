using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class TaskLogDAO : InterfaceDAO<TaskLogDTO>
    {
        private static TaskLogDAO instance;
        public static TaskLogDAO Instance
        {
            get { if (instance == null) instance = new TaskLogDAO(); return instance; }
            private set { instance = value; }
        }
        private TaskLogDAO() { }
        public void Insert(TaskLogDTO taskLog)
        {
            string query = "INSERT INTO TaskLog (TaskID, Action, ActionDate, PerformedBy) VALUES (@taskId, @action, @actionDate, @performedBy)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskId", SqlDbType.Int) { Value = taskLog.TaskID },
                new SqlParameter("@action", SqlDbType.Int) { Value = taskLog.Action },
                new SqlParameter("@actionDate", SqlDbType.DateTime) { Value = taskLog.ActionDate },
                new SqlParameter("@performedBy", SqlDbType.Int) { Value = taskLog.PerformedBy }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            int newId = Convert.ToInt32(result);

            taskLog.TaskLogID = newId;
        }
        public void Update(TaskLogDTO taskLog) 
        {
            string query = "UPDATE TaskLog SET TaskID = @taskId, Action = @action, ActionDate = @actionDate, PerformedBy = @performedBy WHERE TaskLogID = @taskLogID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskId", SqlDbType.Int) { Value = taskLog.TaskID },
                new SqlParameter("@action", SqlDbType.Int) { Value = taskLog.Action },
                new SqlParameter("@actionDate", SqlDbType.DateTime) { Value = taskLog.ActionDate },
                new SqlParameter("@performedBy", SqlDbType.Int) { Value = taskLog.PerformedBy },
                new SqlParameter("@taskLogID", SqlDbType.Int) { Value = taskLog.TaskLogID },
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Delete(TaskLogDTO taskLog) 
        {
            string query = "DELETE FROM TaskLog WHERE TaskLogID = @taskLogID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskLogID", SqlDbType.Int) { Value = taskLog.TaskLogID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
