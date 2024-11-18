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
    public class AttachmentDAO : InterfaceDAO<AttachmentDTO>
    {
        public void Insert(AttachmentDTO attachment)
        {
            string query = "INSERT INTO Attachment (TaskID, FilePath, UploadedBy) VALUES (@taskID, @filePath, @uploadedBy)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = attachment.TaskID },
                new SqlParameter("@filePath", SqlDbType.DateTime) { Value = attachment.FileName },
                new SqlParameter("@uploadedBy", SqlDbType.Int) { Value = attachment.UploadedBy }
            };
            // Lấy ID tự tăng của row vừa tạo và gán vào DTO
            object result = DatabaseAccess.ExecuteScalar(query, parameters);
            int newId = Convert.ToInt32(result);

            attachment.AttachmentID = newId;
        }
        public void Update(AttachmentDTO attachment) 
        {
            string query = "UPDATE Attachment SET TaskID = @taskId, FilePath = @filePath, UploadedBy = @uploadedBy WHERE AttachmentID = @attachmentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = attachment.TaskID },
                new SqlParameter("@filePath", SqlDbType.DateTime) { Value = attachment.FileName },
                new SqlParameter("@uploadedBy", SqlDbType.Int) { Value = attachment.UploadedBy },
                new SqlParameter("@attachmentID", SqlDbType.Int) { Value = attachment.AttachmentID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Delete(AttachmentDTO attachment) 
        {
            string query = "DELETE FROM Attachment WHERE AttachmentID = @attachmentID";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@attachmentID", SqlDbType.Int) { Value = attachment.AttachmentID }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
    }
}
