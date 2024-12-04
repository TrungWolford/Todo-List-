using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DockerVolumeDAO
    {
        private string containerName;
        private string downloadFolder;
        private string dockerPath;
        public DockerVolumeDAO(string containerName, string dockerPath, string downloadFolder)
        {
            this.containerName = containerName;
            this.dockerPath = dockerPath;
            this.downloadFolder = downloadFolder;
        }

        // Upload file từ máy host vào Docker container
        public string UploadFileToDocker(string localFilePath, string taskIDPath)
        {
            try
            {
                // Kiểm tra và tạo thư mục TaskIDPath trong container
                EnsureDirectoryExistsInDocker(taskIDPath);

                // Upload file vào thư mục TaskIDPath
                string fileName = Path.GetFileName(localFilePath);
                string destinationPath = $"{dockerPath}/{taskIDPath}/";

                var uploadProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "docker",
                        Arguments = $"cp \"{localFilePath}\" {containerName}:{destinationPath}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                uploadProcess.Start();
                uploadProcess.WaitForExit();

                if (uploadProcess.ExitCode != 0)
                {
                    string errorMessage = uploadProcess.StandardError.ReadToEnd();
                    throw new Exception($"Error uploading file to Docker: {errorMessage}");
                }

                Console.WriteLine($"File successfully uploaded to Docker: {destinationPath}");

                // Trả về đường dẫn trong container
                return $"/{taskIDPath}/{fileName}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error uploading file: {ex.Message}");
                throw;
            }
        }

        private void EnsureDirectoryExistsInDocker(string taskIDPath)
        {
            var createFolderProcess = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "docker",
                    Arguments = $"exec {containerName} mkdir -p {dockerPath}/{taskIDPath}",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            createFolderProcess.Start();
            createFolderProcess.WaitForExit();

            if (createFolderProcess.ExitCode != 0)
            {
                string errorMessage = createFolderProcess.StandardError.ReadToEnd();
                throw new Exception($"Error creating folder in Docker: {errorMessage}");
            }

            Console.WriteLine($"Directory ensured in Docker: {dockerPath}/{taskIDPath}");
        }
        // Download file từ Docker container về máy host
        public void DownloadFileFromDocker(string filePath)
        {
            try
            {
                // Đảm bảo thư mục download tồn tại
                EnsureDownloadFolderExists();

                // Xây dựng đường dẫn file trên docker
                string dockerFilePath = $"{dockerPath}/{filePath}";

                // Sử dụng Docker CLI để copy file từ container về máy host
                var downloadProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "docker",
                        Arguments = $"cp {containerName}:{dockerFilePath} \"{downloadFolder}\"",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                downloadProcess.Start();
                downloadProcess.WaitForExit();

                // Kiểm tra mã thoát (exit code) để xác định xem lệnh có thành công không
                if (downloadProcess.ExitCode != 0)
                {
                    string errorMessage = downloadProcess.StandardError.ReadToEnd();
                    throw new Exception($"Error downloading file from Docker: {errorMessage}");
                }

                Console.WriteLine($"File successfully downloaded from Docker to: {downloadFolder}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error downloading file: {ex.Message}");
                throw;
            }
        }

        // Hàm phụ để đảm bảo thư mục download tồn tại
        private void EnsureDownloadFolderExists()
        {
            try
            {
                if (!Directory.Exists(downloadFolder))
                {
                    Directory.CreateDirectory(downloadFolder);
                    Console.WriteLine($"Download folder created: {downloadFolder}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error ensuring download folder exists: {ex.Message}");
            }
        }
        public void DeleteFileFromDocker(string filePath)
        {
            try
            {
                // Kiểm tra đường dẫn file hợp lệ
                if (string.IsNullOrEmpty(filePath))
                {
                    throw new ArgumentException("File path must not be null or empty.");
                }

                // Sử dụng Docker CLI để xóa file trong container
                var deleteProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "docker",
                        Arguments = $"exec {containerName} rm -f {dockerPath}/{filePath}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                deleteProcess.Start();
                deleteProcess.WaitForExit();

                // Kiểm tra mã thoát (exit code) để xác định xem lệnh có thành công không
                if (deleteProcess.ExitCode != 0)
                {
                    string errorMessage = deleteProcess.StandardError.ReadToEnd();
                    throw new Exception($"Error deleting file from Docker: {errorMessage}");
                }

                Console.WriteLine($"File successfully deleted from Docker: {dockerPath}/{filePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file: {ex.Message}");
                throw;
            }
        }
        // Hàm xóa thư mục của một task trong Docker
        public void DeleteTaskFolderFromDocker(int taskID)
        {
            try
            {
                string taskIDPath = $"Task_{taskID}";
                // Kiểm tra đường dẫn thư mục hợp lệ
                if (string.IsNullOrEmpty(taskIDPath))
                {
                    throw new ArgumentException("Task folder path must not be null or empty.");
                }

                // Sử dụng Docker CLI để xóa thư mục trong container
                var deleteFolderProcess = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = "docker",
                        Arguments = $"exec {containerName} rm -rf {dockerPath}/{taskIDPath}",
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        UseShellExecute = false,
                        CreateNoWindow = true
                    }
                };

                deleteFolderProcess.Start();
                deleteFolderProcess.WaitForExit();

                // Kiểm tra mã thoát (exit code) để xác định xem lệnh có thành công không
                if (deleteFolderProcess.ExitCode != 0)
                {
                    string errorMessage = deleteFolderProcess.StandardError.ReadToEnd();
                    throw new Exception($"Error deleting folder from Docker: {errorMessage}");
                }

                Console.WriteLine($"Folder successfully deleted from Docker: {dockerPath}/{taskIDPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting folder: {ex.Message}");
                throw;
            }
        }
    }
}
