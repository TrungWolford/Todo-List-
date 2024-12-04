using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class AttachmentBUS
    {
        private static readonly AttachmentDAO attachmentDAO = AttachmentDAO.Instance;
        public AttachmentBUS()
        {

        }
        public bool AddToAttachment(string fileUrl, int TaskID, int UserID)
        {
            AttachmentDTO attachmentDTO = new AttachmentDTO();
            attachmentDTO.TaskID = TaskID;
            attachmentDTO.FilePath = fileUrl;
            attachmentDTO.UploadedBy = UserID;
            return attachmentDAO.Insert(attachmentDTO) != -1;
        }
        public bool DeleteFromAttachment(string fileUrl, int TaskID, int UserID)
        {
            AttachmentDTO attachmentDTO = new AttachmentDTO();
            attachmentDTO.TaskID = TaskID;
            attachmentDTO.FilePath = fileUrl;
            attachmentDTO.UploadedBy = UserID;
            attachmentDTO.AttachmentID = attachmentDAO.GetAttachmentID(attachmentDTO);
            return attachmentDAO.Delete(attachmentDTO) != -1;
        }
        public List<string> GetTaskFiles(int taskId)
        {
            return attachmentDAO.GetTaskFiles(taskId);
        }
    }
}
