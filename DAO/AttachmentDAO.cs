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
    public class AttachmentDAO : InterfaceDAO<AttachmentDTO>
    {
        private static AttachmentDAO instance;
        public static AttachmentDAO Instance
        {
            get { if (instance == null) instance = new AttachmentDAO(); return instance; }
            private set { instance = value; }
        }
        private AttachmentDAO() { }
        public int Insert(AttachmentDTO attachment)
        {
            string query = "INSERT INTO Attachment (TaskID, FilePath, UploadedBy) VALUES (@taskID, @filePath, @uploadedBy); SELECT SCOPE_IDENTITY();";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = attachment.TaskID },
                new SqlParameter("@filePath", SqlDbType.NVarChar) { Value = attachment.FilePath },
                new SqlParameter("@uploadedBy", SqlDbType.Int) { Value = attachment.UploadedBy }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            if (result != null && result != DBNull.Value)
            {
                int newId = Convert.ToInt32(result);
                attachment.AttachmentID = newId;
                return newId;
            }
            return -1;
        }
        public int Update(AttachmentDTO attachment) 
        {
            string query = "UPDATE Attachment SET TaskID = @taskId, FilePath = @filePath, UploadedBy = @uploadedBy WHERE AttachmentID = @attachmentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = attachment.TaskID },
                new SqlParameter("@filePath", SqlDbType.NVarChar) { Value = attachment.FilePath },
                new SqlParameter("@uploadedBy", SqlDbType.Int) { Value = attachment.UploadedBy },
                new SqlParameter("@attachmentID", SqlDbType.Int) { Value = attachment.AttachmentID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }
        public int Delete(AttachmentDTO attachment) 
        {
            string query = "DELETE FROM Attachment WHERE AttachmentID = @attachmentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@attachmentID", SqlDbType.Int) { Value = attachment.AttachmentID }
            };
            int rowsAffected = DatabaseAccess.ExecuteNonQuery(query, parameters);
            if (rowsAffected > 0)
            {
                return rowsAffected;
            }
            return -1; // Không có cập nhật được thực hiện
        }

        public int GetAttachmentID(AttachmentDTO attachment)
        {
            string query = "SELECT AttachmentID FROM Attachment WHERE TaskID = @taskID AND FilePath = @filePath AND UploadedBy = @uploadedBy";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = attachment.TaskID },
                new SqlParameter("@filePath", SqlDbType.NVarChar) { Value = attachment.FilePath },
                new SqlParameter("@uploadedBy", SqlDbType.Int) { Value = attachment.UploadedBy }
            };
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            return result != null ? Convert.ToInt32(result) : -1;
        }

        public List<AttachmentDTO> GetAll()
        {
            throw new NotImplementedException();
        }

        public AttachmentDTO selectedByID(int t)
        {
            throw new NotImplementedException();
        }

        public List<string> GetTaskFiles(int taskID)
        {
            List<string> fileUrls = new List<string>();

            // Truy vấn cơ sở dữ liệu để lấy danh sách URL file
            string query = "SELECT FilePath FROM Attachment WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskID }
            };
            SqlDataReader reader = DatabaseAccess.ExecuteReader(query, parameters);
            while (reader.Read())
            {
                fileUrls.Add(reader["FilePath"].ToString());
            }
            return fileUrls;
        }
        public int DeleteTaskAttachments(int taskID)
        {
            string query = "DELETE FROM [Attachment] WHERE TaskID = @taskID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = taskID }
            };
            return DatabaseAccess.ExecuteNonQuery(query, parameters) > 0 ? 1 : -1;
        }
    }
}
