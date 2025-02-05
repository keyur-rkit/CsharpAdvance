using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// class to show different syntax of LINQ
    /// </summary>
    public class SyntaxOfLINQ
    {
        /// <summary>
        /// method to show different syntax of LINQ
        /// </summary>
        public static void RunSyntaxOfLINQDemo()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Query Syntax");

            List<int> querySyntax = (from num in numbers
                              where num > 5
                              select num).ToList();

            foreach (int num in querySyntax)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            Console.WriteLine("Method Syntax");

            List<int> methodSyntax = numbers.Where(num => num % 2 == 0).ToList();

            foreach (int num in methodSyntax)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();

            Console.WriteLine("Mixed Syntax");

            int mixedSyntax = (from num in numbers
                               select num).Max();

            Console.WriteLine(mixedSyntax);
        }
    }
}
