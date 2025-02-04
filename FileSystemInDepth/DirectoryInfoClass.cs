using System;
using System.IO;

namespace FileSystemInDepth
{
    /// <summary>
    /// Demonstrates usage of DirectoryInfo to manage directories and retrieve information.
    /// </summary>
    public class DirectoryInfoClass
    {
        #region Public Methods

        /// <summary>
        /// Demonstrates how to check, create, and list contents of a directory using DirectoryInfo.
        /// </summary>
        public static void RunDirectoryInfoClassDemo()
        {
            string dirPath = @"F:\Keyur-417\Code\CsharpAdvance\FileSystemInDepth\test";
            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);

            if (dirInfo.Exists)
            {
                Console.WriteLine("That directory exists already");
            }
            else
            {
                dirInfo.Create();
                Console.WriteLine("Directory Created");
            }

            Console.WriteLine();
            Console.WriteLine("DirectoryInfo Properties:");
            Console.WriteLine($"FullName = {dirInfo.FullName}");
            Console.WriteLine($"Name = {dirInfo.Name}");
            Console.WriteLine($"Parent = {dirInfo.Parent}");
            Console.WriteLine($"Root = {dirInfo.Root}");

            Console.WriteLine();

            // List subdirectories
            DirectoryInfo[] dirArr = dirInfo.GetDirectories();
            foreach (DirectoryInfo dir in dirArr)
            {
                Console.WriteLine(dir.Name);
            }

            Console.WriteLine();

            // List files
            FileInfo[] fileInfos = dirInfo.GetFiles();
            foreach (FileInfo fileInfo in fileInfos)
            {
                Console.WriteLine(fileInfo.Name);
            }

            // Uncomment to delete the directory
            //dirInfo.Delete();
            //Console.WriteLine("Directory Deleted");
        }

        #endregion
    }
}
