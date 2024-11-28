//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using DAO;

//namespace BUS
//{
//    internal class AttachmentBUS
//    {
//        private readonly DockerRepository dockerRepository; // Tham chiếu tới lớp Data Access Layer
//        private readonly List<string> uploadedFiles; // Lưu danh sách file đã tải lên

//        public AttachmentBUS()
//        {
//            dockerRepository = new DockerRepository();
//            uploadedFiles = new List<string>();
//        }

//        public Result AddFile(string filePath)
//        {
//            // Kiểm tra file có hợp lệ không
//            if (uploadedFiles.Contains(filePath))
//            {
//                return new Result(false, "File đã được thêm trước đó.");
//            }

//            // Gửi file tới Docker qua Data Access Layer
//            bool success = dockerRepository.UploadFileToDocker(filePath);
//            if (success)
//            {
//                uploadedFiles.Add(filePath);
//                return new Result(true, "Thêm file thành công.");
//            }
//            else
//            {
//                return new Result(false, "Thêm file không thành công.");
//            }
//        }

//        public bool RemoveFile(string filePath)
//        {
//            if (uploadedFiles.Contains(filePath))
//            {
//                // Xóa file trong Docker
//                bool success = dockerRepository.DeleteFileFromDocker(filePath);
//                if (success)
//                {
//                    uploadedFiles.Remove(filePath);
//                    return true;
//                }
//            }
//            return false;
//        }
//    }

//    public class Result
//    {
//        public bool Success { get; set; }
//        public string Message { get; set; }

//        public Result(bool success, string message)
//        {
//            Success = success;
//            Message = message;
//        }
//    }
//}
