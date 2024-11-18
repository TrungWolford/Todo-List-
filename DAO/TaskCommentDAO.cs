﻿using System;
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
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            int newId = Convert.ToInt32(result);

            taskComment.CommentID = newId;
        }

        public void Update(TaskCommentDTO taskComment) 
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
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Delete(TaskCommentDTO taskComment) 
        {
            string query = "DELETE FROM TaskAssignment WHERE CommentID = @commentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@commentID", SqlDbType.Int) { Value = taskComment.CommentID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
