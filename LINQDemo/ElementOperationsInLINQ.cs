using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// Class to show ElementOperations In LINQ Demo
    /// </summary>
    public class ElementOperationsInLINQ
    {
        /// <summary>
        /// Method to show Element Operations
        /// </summary>
        public static void RunElementOperationsInLINQDemo()
        {
            // Element operators : ElementAt , ElementAtOrDefault , First , FirstOrDefault 
            // Last , LastOrDefault , Single , SingleOrDefault

            List<int> nums = new List<int> { 1,2,3,4,5,6,7,8};
            List<string> names = new List<string> { "Keyur" , "Hit" , "Meet" };

            // ElementAt , ElementAtOrDefault
            int elementAt = nums.ElementAt(0);
            int elementAtOrDefaultNums = nums.ElementAtOrDefault(-1);
            string elementAtOrDefaultNames= names.ElementAtOrDefault(-1);

            // First , FirstOrDefault
            int first = nums.First(n => n > 3);
            int firstOrDefaultNums = nums.FirstOrDefault(n => n > 9);
            string firstOrDefaultNamems = names.FirstOrDefault(n => n.Length > 6);

            // Last , LastOrDefault
            int last = nums.Last();
            int lastOrDefaultNums = nums.LastOrDefault(n => n > 9);
            string lastOrDefaultNames = names.LastOrDefault(n => n.Length > 9);

            // Single , SingleOrDefault
            int single = nums.Single(n => n < 2);
            int singleOrDefaultNums = nums.SingleOrDefault(n => n < -1);
            string singleOrDefaultNamems = names.SingleOrDefault(n => n.Length > 6);

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
