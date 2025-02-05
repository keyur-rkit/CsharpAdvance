using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// class to show Partitioning in LINQ
    /// </summary>
    public class PartitioningInLINQ
    {
        /// <summary>
        /// method to show Partitioning in LINQ
        /// </summary>
        public static void RunPartitioningInLINQDemo()
        {
            // Partitioning Operators : Take, TakeWhile , Skip, SkipWhile

            List<int> nums = new List<int> { 1,2,3,4,5,6,7,8,9,10,3,4,5};
            List<string> names = new List<string> { "Keyur", "Meet", "Vivek", "Hit", "Drashti" };

            // Take
            List<int> takeNums = nums.Take(5).ToList();
            List<int> takeWhereNums = nums.Take(5).Where(n => n > 3).ToList();
            List<int> whereTakeNums = nums.Where(n => n > 3).Take(5).ToList();

            // TakeWhile
            List<int> takeWhileNums = nums.TakeWhile(n => n < 6).ToList();
            List<string> takeWhileNames = names.TakeWhile((name,index) => name.Length > index).ToList();

            // Skip
            List<int> skipNums = nums.Skip(5).ToList();
            List<int> whereSkipNums = nums.Where(n => n > 4).Skip(3).ToList();

            // SkipWhile
            List<int> skipWhileNums = nums.SkipWhile(n => n < 5).ToList();
            List<string> skipWhileNames = names.SkipWhile((name,index) => name.Length > index).ToList();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
