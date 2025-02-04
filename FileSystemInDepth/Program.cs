namespace FileSystemInDepth
{
    /// <summary>
    /// Main class to demonstrate file system operations using various classes like DirectoryInfo, FileInfo, etc.
    /// </summary>
    public class Program
    {
        #region Public Methods

        /// <summary>
        /// Entry point for the application, running demos for file system operations.
        /// </summary>
        /// <param name="args">Command line arguments (if any).</param>
        public static void Main(string[] args)
        {
            DirectoryInfoClass.RunDirectoryInfoClassDemo();

            // FileInfoClass.RunFileInfoClassDemo();

            // OtherFileClass.RunOtherFileClassDemo();

        }

        #endregion
    }
}
