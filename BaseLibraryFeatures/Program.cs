
namespace BaseLibraryFeatures
{
    /// <summary>
    ///  Entry point for the program
    /// </summary>
    class Program
    {
        /// <summary>
        /// Main method that demonstrates CustomWriter
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            string path = @"F:\Keyur-417\Code\CsharpAdvance\BaseLibraryFeatures\Data\Test.txt";

            using(var cw = new CustomWriter(path))
            {
                cw.WriteLine("this is some dummy data!");
                cw.WriteLine("this is second line of dummy data!!");
                cw.WriteLine("here is my name : keyur");
            }
        }
    }
}