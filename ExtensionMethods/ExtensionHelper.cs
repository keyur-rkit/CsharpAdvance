using System;

namespace ExtensionMethods
{
    /// <summary>
    /// Contains extension methods for various types to demonstrate extension method functionality.
    /// </summary>
    public static class ExtensionHelper
    {
        #region Extension Methods

        /// <summary>
        /// Extension method to print all items in a list.
        /// </summary>
        /// <typeparam name="T">The type of elements in the list.</typeparam>
        /// <param name="items">The list of items to be printed.</param>
        public static void Print<T>(this List<T> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// Extension method to print a message for objects implementing IEmployee.
        /// </summary>
        /// <param name="emp">The employee object.</param>
        public static void DoSomething(this IEmployee emp)
        {
            Console.WriteLine("Method Extended to Interface IEmployee");
        }

        #endregion
    }

    #region Interfaces and Classes

    /// <summary>
    /// Interface that represents an employee.
    /// </summary>
    public interface IEmployee
    {

    }

    /// <summary>
    /// Class representing a basic employee , implementing from IEmployee.
    /// </summary>
    public class Employee : IEmployee
    {

    }

    /// <summary>
    /// Class representing a manager, implementing from IEmployee.
    /// </summary>
    public class Manager : IEmployee
    {

    }

    #endregion
}
