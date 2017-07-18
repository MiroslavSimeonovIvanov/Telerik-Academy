using System;

namespace CohesionAndCoupling
{
    public class File
    {
        public static string GetFileNameExtension(string fileName)
        {
            if (fileName == null || fileName.Length == 0)
            {
                throw new NullReferenceException("You should enter a name of the file.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            string fileNameExtension = fileName.Substring(indexOfLastDot + 1);

            if (fileNameExtension == fileName)
            {
                fileNameExtension = null;
            }

            return fileNameExtension;
        }

        public static string GetFileNameWithoutExtension(string fileName)
        {
            if (fileName == null || fileName.Length == 0)
            {
                throw new NullReferenceException("You should enter a name of the file.");
            }

            int indexOfLastDot = fileName.LastIndexOf(".");
            string fileNameWithoutExtension = fileName.Substring(0, indexOfLastDot + 1);
            return fileNameWithoutExtension;
        }
    }
}
