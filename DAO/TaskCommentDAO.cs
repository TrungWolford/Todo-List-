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
    public class TaskCommentDAO : InterfaceDAO<TaskCommentDTO>
    {
        private static TaskCommentDAO instance;
        public static TaskCommentDAO Instance
        {
            get { if (instance == null) instance = new TaskCommentDAO(); return instance; }
            private set { instance = value; }
        }
        private TaskCommentDAO() { }
        public int Insert(TaskCommentDTO taskComment)
        {
            string query = "INSERT INTO TaskComment (UserID, TaskID, Comment, CreatedDate) VALUES (@userID, @taskID, @comment, @createdDate); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = taskComment.UserID },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskComment.TaskID },
                new SqlParameter("@comment", SqlDbType.NVarChar) { Value = taskComment.CommentText },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = taskComment.CreatedDate }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                taskComment.CommentID = newId;
                return newId;
            }
            return -1;
        }

        public int Update(TaskCommentDTO taskComment) 
        {
            string query = "UPDATE TaskComment SET UserID = @userID, TaskID = @taskID, Comment = @comment, CreatedDate = @createdDate WHERE CommentID = @commentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = taskComment.UserID },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskComment.TaskID },
                new SqlParameter("@comment", SqlDbType.NVarChar) { Value = taskComment.CommentText },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = taskComment.CreatedDate },
                new SqlParameter("@commentID", SqlDbType.Int) { Value = taskComment.CommentID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(TaskCommentDTO taskComment) 
        {
            string query = "DELETE FROM TaskAssignment WHERE CommentID = @commentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@commentID", SqlDbType.Int) { Value = taskComment.CommentID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }

        public List<TaskCommentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public TaskCommentDTO selectedByID(int t)
        {
            throw new NotImplementedException();
        }
    }
}
