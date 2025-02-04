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
            var takeNums = nums.Take(5).ToList();
            var takeWhereNums = nums.Take(5).Where(n => n > 3).ToList();
            var whereTakeNums = nums.Where(n => n > 3).Take(5).ToList();

            // TakeWhile
            var takeWhileNums = nums.TakeWhile(n => n < 6).ToList();
            var takeWhileNames = names.TakeWhile((name,index) => name.Length > index).ToList();

            // Skip
            var skipNums = nums.Skip(5).ToList();
            var whereSkipNums = nums.Where(n => n > 4).Skip(3).ToList();

            // SkipWhile
            var skipWhileNums = nums.SkipWhile(n => n < 5).ToList();
            var skipWhileNames = names.SkipWhile((name,index) => name.Length > index).ToList();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
