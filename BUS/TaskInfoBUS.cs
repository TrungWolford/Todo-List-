using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Drawing;

namespace BUS
{
    public class TaskInfoBUS
    {
        private TaskDAO taskDAO = TaskDAO.Instance;
        private AttachmentDAO attachmentDAO = AttachmentDAO.Instance;

        private readonly DockerVolumeDAO dockerDAO;

        private string containerName = "sql_server_container";
        private string downloadFolder = @"C:\Downloads";
        private string dockerPath = @"/var/opt/mssql/data/TaskAttachments/";

        public TaskInfoBUS()
        {
            dockerDAO = new DockerVolumeDAO(containerName, dockerPath, downloadFolder);
        }

        // Upload file vào Docker container
        public string UploadFile(string localFilePath, int taskID)
        {
            string taskIDPath = $"Task_{taskID}";
            // Thực hiện upload file và lưu lại đường dẫn file trong docker
            string filePath = dockerDAO.UploadFileToDocker(localFilePath, taskIDPath);

            return filePath;
        }

        // Download file từ Docker container về thư mục Downloads
        public void DownloadFile(string filePath)
        {
            dockerDAO.DownloadFileFromDocker(filePath);
        }

        public void DeleteFile(string filePath)
        {
            dockerDAO.DeleteFileFromDocker(filePath);
        }
        
        public void DeleteTaskFiles(int taskID)
        {
            dockerDAO.DeleteTaskFolderFromDocker(taskID);
            attachmentDAO.DeleteTaskAttachments(taskID);
        }

        public TaskDTO SelectByTaskID(int taskID)
        {
            return taskDAO.SelectByTaskID(taskID);
        }
        public void UpdateTaskInfo(TaskDTO task)
        {
            taskDAO.Update(task);
        }
        public void DeleteTask(TaskDTO task)
        {
            taskDAO.Delete(task);
        }
    }
}
