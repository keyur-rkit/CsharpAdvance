using System;
using System.Linq;

namespace LambdaExpression
{
    /// <summary>
    /// Represents a student with properties for roll number and name.
    /// </summary>
    public class Student
    {
        #region public properties

        public int RollNo { get; set; }
        public string stuName { get; set; }

        #endregion
    }

    /// <summary>
    /// Main program class that demonstrates the usage of Lambda Expression
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of the program that demonstrates working with lambda expressions
        /// </summary>
        /// <param name="args">Command line arguments (not used in this example).</param>
        public static void Main(string[] args)
        {
            #region Book List and Lambda Operations

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

            // Displaying each book in the list
            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            // Using Lambda Expression to convert all book names to uppercase
            IEnumerable<string> uppercaseBooks = books.Select(b => b.ToUpper());

            // Displaying the books in uppercase
            foreach (string book in uppercaseBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            // Using Lambda Expression to filter books with name length greater than or equal to 15 characters
            IEnumerable<string> filteredBooks = books.Where(b => b.Length >= 15);

            // Displaying filtered books
            foreach (string book in filteredBooks)
            {
                Console.WriteLine(book);
            }

            Console.WriteLine();

            #endregion

            #region Student List and Lambda Operations

            // Creating a list of student details
            List<Student> details = new List<Student>() {
                new Student{ RollNo = 1, stuName = "keyur" },
                new Student{ RollNo = 2, stuName = "meet" },
                new Student{ RollNo = 3, stuName = "hit" },
                new Student{ RollNo = 4, stuName = "vivek" },
                new Student { RollNo = 5, stuName = "drashti" }
            };

            // Using Lambda Expression to sort students by their names
            var newDetails = details.OrderBy(x => x.stuName);

            // Displaying the ordered list of students
            foreach (var value in newDetails)
            {
                Console.WriteLine(value.RollNo + " " + value.stuName);
            }

            #endregion
        }
    }
}
