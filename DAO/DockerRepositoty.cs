using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DockerRepository
    {
        private readonly string dockerVolumePath;

        public DockerRepository(string volumePath)
        {
            dockerVolumePath = volumePath;
        }

        public bool CopyFileToVolume(string sourceFilePath, string destinationFileName)
        {
            try
            {
                string destinationPath = Path.Combine(dockerVolumePath, destinationFileName);
                File.Copy(sourceFilePath, destinationPath, overwrite: true);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error copying file to Docker volume: {ex.Message}");
                return false;
            }
        }

        public bool RemoveFileFromVolume(string fileName)
        {
            try
            {
                string filePath = Path.Combine(dockerVolumePath, fileName);
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting file from Docker volume: {ex.Message}");
                return false;
            }
        }
    }
}
