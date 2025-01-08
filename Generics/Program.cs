namespace Generics
{
    /// <summary>
    /// Represents an employee with generic data type.
    /// </summary>
    /// <typeparam name="T">The data type of the employee's information.</typeparam>
    public class Employee<T>
    {
        public T data;

        /// <summary>
        /// Initializes a new instance of the Employee class with specified data.
        /// </summary>
        /// <param name="data">The data of the employee.</param>
        public Employee(T data)
        {
            this.data = data;
            Console.WriteLine($"Data Passed : {data}");
        }
    }

    /// <summary>
    /// Defines the operations of a menu interface that takes generic data type.
    /// </summary>
    /// <typeparam name="T">The data type for the menu order (e.g., string, int).</typeparam>
    interface IMenu<T>
    {
        /// <summary>
        /// Processes the order based on the generic data type.
        /// </summary>
        /// <param name="data">The data related to the menu item (could be item name, ID, etc.).</param>
        void Order(T data);
    }

    /// <summary>
    /// Represents a hotel menu where orders are placed with a string (food item name).
    /// </summary>
    class Hotel1 : IMenu<string>
    {
        /// <summary>
        /// Processes the order by food item name.
        /// </summary>
        /// <param name="itemName">The name of the food item being ordered.</param>
        public void Order(string itemName)
        {
            Console.WriteLine($"Food Item name : {itemName}");
        }
    }

    /// <summary>
    /// Represents a hotel menu where orders are placed with an integer (food item ID).
    /// </summary>
    class Hotel2 : IMenu<int>
    {
        /// <summary>
        /// Processes the order by food item ID.
        /// </summary>
        /// <param name="itemID">The ID of the food item being ordered.</param>
        public void Order(int itemID)
        {
            Console.WriteLine($"Food Item ID : {itemID}");
        }
    }

    /// <summary>
    /// Entry point of the program that demonstrates generic classes, methods, and interfaces.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Compares two values of the same type for equality.
        /// </summary>
        /// <typeparam name="T">The data type of the values being compared.</typeparam>
        /// <param name="val1">The first value to compare.</param>
        /// <param name="val2">The second value to compare.</param>
        /// <returns>Returns true if the values are equal, otherwise false.</returns>
        public static bool AreEqual<T>(T val1, T val2)
        {
            return val1.Equals(val2);
        }

        /// <summary>
        /// Main method demonstrating the use of generics in classes, methods, and interfaces.
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            // Generic class
            Employee<string> emp1Name = new Employee<string>("Keyur");
            Employee<int> emp2ID = new Employee<int>(417);

            Console.WriteLine();

            // Generic method
            Console.WriteLine($"Int Comparation result : {AreEqual<int>(107, 107)}");
            Console.WriteLine($"String Comparation result : {AreEqual<string>("keyur", "keyur")}");

            Console.WriteLine();

            // Generic interface
            Hotel1 item1 = new Hotel1();
            item1.Order("Vadapav");

            Hotel2 item2 = new Hotel2();
            item2.Order(10);

        }
    }
}
