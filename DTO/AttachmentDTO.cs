using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    internal class AttachmentDTO
    {
        public int AttachmentID { get; set; }
        public int TaskID { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public string UploadedBy { get; set; }

        public AttachmentDTO() { }

        public AttachmentDTO(int attachmentID, int taskID, string filePath, string fileName, string uploadedBy)
        {
            AttachmentID = attachmentID;
            TaskID = taskID;
            FilePath = filePath;
            FileName = fileName;
            UploadedBy = uploadedBy;
        }

        public override string ToString()
        {
            return $"AttachmentDTO [AttachmentID={AttachmentID}, TaskID={TaskID}, FilePath={FilePath}, FileName={FileName}, UploadedBy={UploadedBy}]";
        }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            var other = (AttachmentDTO)obj;
            return AttachmentID == other.AttachmentID &&
                   TaskID == other.TaskID &&
                   FilePath == other.FilePath &&
                   FileName == other.FileName &&
                   UploadedBy == other.UploadedBy;
        }

        public override int GetHashCode()
        {
            int hash = 17;
            hash = hash * 31 + AttachmentID.GetHashCode();
            hash = hash * 31 + TaskID.GetHashCode();
            hash = hash * 31 + (FilePath != null ? FilePath.GetHashCode() : 0);
            hash = hash * 31 + (FileName != null ? FileName.GetHashCode() : 0);
            hash = hash * 31 + (UploadedBy != null ? UploadedBy.GetHashCode() : 0);
            return hash;
        }
    }
}
