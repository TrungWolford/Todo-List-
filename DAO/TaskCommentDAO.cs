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
    public class TaskCommentDAO : InterfaceDAO<TaskCommentDTO>
    {
        public void Insert(TaskCommentDTO taskComment)
        {
            string query = "INSERT INTO TaskComment (UserID, TaskID, Comment, CreatedDate) VALUES (@userID, @taskID, @comment, @createdDate)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@userID", SqlDbType.Int) { Value = taskComment.UserID },
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskComment.TaskID },
                new SqlParameter("@comment", SqlDbType.NVarChar) { Value = taskComment.CommentText },
                new SqlParameter("@createdDate", SqlDbType.DateTime) { Value = taskComment.CreatedDate }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }

        public void Update(TaskCommentDTO taskComment) { }
        public void Delete(TaskCommentDTO taskComment) { }
    }
}
