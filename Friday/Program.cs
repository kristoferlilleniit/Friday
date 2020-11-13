using System;
using System.IO;

namespace Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteFilePath();
            WriteDirectoryPath();
        }

        public static void WriteFilePath()
        {
            string filepath = @"C:\Users\opilane\Friday\sampleFiles.txt";
            string directoryPath = @"C:\Users\opilane\Samples";
            string folderfilepath = @"C:\Users\opilane\Friday\sampleDirectories.txt";
            string[] files = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories);
            File.WriteAllLines(filepath, files);
        }

        public static void WriteDirectoryPath()
        {
            string rootpath = @"C:\Users\opilane\Samples";
            string folderfilepath = @"C:\Users\opilane\Friday\sampleDirectories.txt";
            string[] allDirectories = Directory.GetDirectories(rootpath);
            File.WriteAllLines(folderfilepath, allDirectories);

            string[] includeNestedDirectories = Directory.GetDirectories(rootpath, "*.*", SearchOption.AllDirectories);
            File.WriteAllLines(folderfilepath, includeNestedDirectories);
        }

    }
}
