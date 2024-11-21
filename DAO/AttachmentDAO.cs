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
                new SqlParameter("@filePath", SqlDbType.NVarChar) { Value = attachment.FileName },
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
                new SqlParameter("@filePath", SqlDbType.NVarChar) { Value = attachment.FileName },
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

        public List<AttachmentDTO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
