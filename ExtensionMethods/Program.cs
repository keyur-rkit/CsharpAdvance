using System;
using System.Linq;

namespace ExtensionMethods
{
    /// <summary>
    /// Entry point of the program that demonstrates the use of extension methods.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main method that demonstrates the usage of extension methods.
        /// </summary>
        /// <param name="args">Command line arguments.</param>
        public static void Main(string[] args)
        {
            #region Extension method in List and LINQ

            // Creating a list of book names
            List<string> books = new List<string>
            {
                "The Silent Observer",
                "Whispers of the Past",
                "Shadows in the Moonlight",
                "Journey Through Time",
                "The Lost City",
                "Echoes of the Forgotten"
            };

            // Calling an extension method to print the books
            books.Print();

            // Most LINQ methods are Extension Methods
            List<string> longNameBooks = books.Where(b => b.Length > 20).ToList();

            Console.WriteLine();

            #endregion

            #region Extension method in interface

            // Creating Employee and Manager objects to demonstrate method calls
            Employee employee = new Employee();
            Manager manager = new Manager();

            // Calling the DoSomething method for both Employee and Manager objects
            employee.DoSomething();
            manager.DoSomething();

            #endregion
        }
    }
}
