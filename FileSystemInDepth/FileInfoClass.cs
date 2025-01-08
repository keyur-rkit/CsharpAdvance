using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemInDepth
{
    /// <summary>
    /// Demonstrates usage of FileInfo to manage files and retrieve file properties.
    /// </summary>
    class FileInfoClass
    {
        #region Public Methods

        /// <summary>
        /// Demonstrates how to check, create, and manipulate file properties using FileInfo.
        /// </summary>
        public static void RunFileInfoClassDemo()
        {
            string filePath = @"F:\Keyur-417\Code\CsharpAdvance\FileSystemInDepth\test\testFile.txt";

            FileInfo file = new FileInfo(filePath);

            if(file.Exists)
            {
                Console.WriteLine("File already exists");
            }
            else
            {
                file.Create();
                Console.WriteLine("File Created");
            }

            Console.WriteLine();
            Console.WriteLine("FileInfo Properties : ");
            Console.WriteLine($"Directory =  {file.Directory}");
            Console.WriteLine($"Directory Name =  {file.DirectoryName}");
            Console.WriteLine($"Length =  {file.Length}");
            Console.WriteLine($"Name =  {file.Name}");


            // to Encrypt file so that no other user can access it
            file.Encrypt();


            // to decrypt encrypted file so that everyone can access it
            // file.Decrypt();



            // file.Delete();
            // Console.WriteLine("File Deleted");
        }

        #endregion
    }
}

