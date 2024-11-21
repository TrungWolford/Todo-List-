using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Net.Mail;

namespace DAO
{
    public class TaskAssignmentDAO : InterfaceDAO<TaskAssignmentDTO>
    {
        private static TaskAssignmentDAO instance;
        public static TaskAssignmentDAO Instance
        {
            get { if (instance == null) instance = new TaskAssignmentDAO(); return instance; }
            private set { instance = value; }
        }
        private TaskAssignmentDAO() { }
        public int Insert(TaskAssignmentDTO taskAssignment)
        {
            string query = "INSERT INTO TaskAssignment (UserID, TaskID, AssignedBy, AssignedDate) VALUES (@userID, @taskID, @assignedBy, @assignedDate); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = taskAssignment.UserID },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskAssignment.TaskID },
                new SqlParameter("@assignedBy", SqlDbType.Int) { Value = taskAssignment.AssignedBy },
                new SqlParameter("@assignedDate", SqlDbType.DateTime) { Value = taskAssignment.AssignedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                taskAssignment.AssignmentID = newId;
                return newId;
            }
            return -1;
        }

        public int Update(TaskAssignmentDTO taskAssignment) 
        {
            string query = "UPDATE TaskAssignment SET UserID = @userID, TaskID = @taskID, AssignedBy = @assignedBy, AssignedDate = @assignedDate WHERE AssignmentID = @assignmentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = taskAssignment.UserID },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskAssignment.TaskID },
                new SqlParameter("@assignedBy", SqlDbType.Int) { Value = taskAssignment.AssignedBy },
                new SqlParameter("@assignedDate", SqlDbType.DateTime) { Value = taskAssignment.AssignedDate },
                new SqlParameter("@AssignmentID", SqlDbType.Int) { Value = taskAssignment.AssignmentID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(TaskAssignmentDTO taskAssignment) 
        {
            string query = "DELETE FROM TaskAssignment WHERE AssignmentID = @assignmentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@assignmentID", SqlDbType.Int) { Value = taskAssignment.AssignmentID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
    }
}
