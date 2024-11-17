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
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Update(TaskLogDTO taskLog) { }
        public void Delete(TaskLogDTO taskLog) { }
    }
}
