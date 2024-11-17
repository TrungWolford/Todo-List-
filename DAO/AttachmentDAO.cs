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
        public void Insert(AttachmentDTO attachmentDTO)
        {
            string query = "INSERT INTO Attachment (TaskID, FilePath, UploadedBy) VALUES (@taskID, @filePath, @uploadedBy)";
            List<SqlParameter> parameters = new List<SqlParameter>
            {
                new SqlParameter("@taskID", SqlDbType.Int) { Value = attachmentDTO.TaskID },
                new SqlParameter("@filePath", SqlDbType.DateTime) { Value = attachmentDTO.FileName },
                new SqlParameter("@uploadedBy", SqlDbType.Int) { Value = attachmentDTO.UploadedBy }
            };
            DatabaseAccess.ExecuteNonQuery(query, parameters);
        }
        public void Update(AttachmentDTO attachmentDTO) { }
        public void Delete(AttachmentDTO attachmentDTO) { }
    }
}
