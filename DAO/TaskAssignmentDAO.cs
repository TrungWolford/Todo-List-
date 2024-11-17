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
    public class TaskAssignmentDAO : InterfaceDAO<TaskAssignmentDTO>
    {
        public void Insert(TaskAssignmentDTO taskAssignment)
        {
            string query = "INSERT INTO TaskAssignment (UserID, TaskID, AssignedBy, AssignedDate) VALUES (@userID, @taskID, @assignedBy, @assignedDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = taskAssignment.UserID },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskAssignment.TaskID },
                new SqlParameter("@assignedBy", SqlDbType.Int) { Value = taskAssignment.AssignedBy },
                new SqlParameter("@assignedDate", SqlDbType.DateTime) { Value = taskAssignment.AssignedDate }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }

        public void Update(TaskAssignmentDTO taskAssignment) { }
        public void Delete(TaskAssignmentDTO taskAssignment) { }
    }
}
