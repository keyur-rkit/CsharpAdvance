using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// class to show Set Operations
    /// </summary>
    public class SetOperationsInLINQ
    {
        /// <summary>
        /// method to show Set Operations
        /// </summary>
        public static void RunSetOperationsInLINQDemo()
        {
            // set operations : Distinct, Expect, Intersect, Union

            //Distinct
            List<int> nums= new List<int> { 1,2,3,2,1,2,3,5,4,3,2,1 };
            List<string> names = new List<string> { "keyur", "Keyur", "Keyur", "Hit", "Meet" };

            List<int> distinctNums = nums.Distinct().ToList();
            List<string> distinctNames = names.Distinct().ToList();

            
            List<string> data1 = new List<string> { "Keyur", "Keyur", "Hit", "Meet" };
            List<string> data2 = new List<string> { "Hit", "Meet" };

            // Expect
            List<string> expectData = data1.Except(data2).ToList();
            // Intersect
            List<string> intersectData = data1.Intersect(data2).ToList();
            // Union
            List<string> unionData = data1.Union(data2).ToList();


            Console.WriteLine(  );
            Console.ReadLine();
        }
    }
}
