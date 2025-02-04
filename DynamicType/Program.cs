

namespace DynamicType
{
    /// <summary>
    /// Boook class 
    /// </summary>
    public class Book
    {
        public dynamic Id { get; set; }
        public dynamic Title { get; set; }

    }

    /// <summary>
    /// Entry point for the program
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Method to return dynamic type
        /// </summary>
        /// <param name="dynamicValue"></param>
        /// <returns></returns>
        public static dynamic ReturnType (dynamic dynamicValue)
        {
            return dynamicValue.GetType();
        }

        /// <summary>
        /// Main method that perform dynamic type
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            dynamic dynamicInt = 107;
            dynamic dynamicDouble = 107.106;
            dynamic dynamicChar = 'k';
            dynamic dynamicStr = "Keyur";
            dynamic dynamicBool = false;
            dynamic dynamicDateTime = DateTime.Now;

            dynamic dynamicBookObj = new Book { Id = 123, Title = "Book1" };

            Console.WriteLine(ReturnType(dynamicInt));
            Console.WriteLine(ReturnType(dynamicDouble));
            Console.WriteLine(ReturnType(dynamicChar));
            Console.WriteLine(ReturnType(dynamicStr));
            Console.WriteLine(ReturnType(dynamicBool));
            Console.WriteLine(ReturnType(dynamicDateTime));
            Console.WriteLine(ReturnType(dynamicBookObj));
        }
    }
}