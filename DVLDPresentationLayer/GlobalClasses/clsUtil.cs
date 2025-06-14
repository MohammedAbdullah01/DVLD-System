using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDPresentationLayer.GlobalClasses
{
    public class clsUtil
    {
        public static string FormatPhoneNumber(string phoneNumber)
        {
            if (phoneNumber.Length == 10)
            {
                return $"{phoneNumber.Substring(0, 3)}-{phoneNumber.Substring(3, 3)}-{phoneNumber.Substring(6, 4)}";
            }
            return phoneNumber; 
        }
        public static string FormatCurrency(decimal amount)
        {
            return amount.ToString("C2"); 
        }

        public static string FormatPercentage(decimal value)
        {
            return $"{value:P2}"; 
        }

        public static string GenerateGUID()
        {
            return Guid.NewGuid().ToString(); 
        }


       //Generate Function to Create Folder if Does NotExist
        public static void CreateFolderIfNotExists(string folderPath)
        {
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }
        }

        // Generate function replace file name with guid 
        public static string ReplaceFileNameWithGUID(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                string directory = System.IO.Path.GetDirectoryName(filePath);
                string extension = System.IO.Path.GetExtension(filePath);
                string newFileName = $"{Guid.NewGuid()}{extension}";
                return System.IO.Path.Combine(directory, newFileName);
            }
            return filePath;
        }

        // Generate function copy image to project images folder  return bool
        public static bool CopyImageToProjectImagesFolder(string sourceFilePath, string destinationFolderPath)
        {
            try
            {
                CreateFolderIfNotExists(destinationFolderPath);
                string fileName = System.IO.Path.GetFileName(sourceFilePath);
                string destinationFilePath = System.IO.Path.Combine(destinationFolderPath, fileName);
                System.IO.File.Copy(sourceFilePath, destinationFilePath, true);
                return true;
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed
                Console.WriteLine($"Error copying image: {ex.Message}");
                return false;
            }
        }

        public static void DeleteFolder(string folderPath)
        {
            if (System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.Delete(folderPath, true);
            }
        }   

    }
}
