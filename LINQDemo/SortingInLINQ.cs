using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// Class to show sorting in LINQ
    /// </summary>
    public class SortingInLINQ
    {
        // Sorting operators : OrderBy , OrderBYDescending , ThenBy , ThenBYDescending , Reverse
    
        /// <summary>
        /// method to show Sorting in LINQ
        /// </summary>
        public static void RunSortinhInLINQDemo()
        {
            List<int> nums = new List<int> { 5, 8, 7, 4, 1, 10, 9, 6, 4, 1, 8 };

            List<Student> students = new List<Student>
            {
                new Student{Id = 5,Name = "Meet",Email = "meet@gmail.com" },
                new Student{Id = 2,Name = "Hit",Email = "hit@gmail.com" },
                new Student{Id = 1,Name = "Keyur",Email = "keyur@gmail.com" },
                new Student{Id = 4,Name = "Drashti",Email = "drashti@gmail.com" },
                new Student{Id = 3,Name = "Vivek",Email = "vivek@gmail.com" }
            };

            // OrderBy
            List<int> orderByIntQuery = (from num in nums
                                  where num<9
                                  orderby num
                                  select num).ToList();

            List<int> orderByIntMethod = nums.Where(num => num<9).OrderBy(num => num).ToList();

            List<Student> orderByObjQuery = (from stu in students
                                   orderby stu.Name
                                   select stu).ToList();

            List<Student> orderByObjMethod = students.OrderBy(stu => stu.Id).ToList();

            // OrderByDescending
            List<int> orderByDescIntQuery = (from num in nums
                                       where num<9
                                       orderby num descending
                                       select num).ToList();

            List<int> orderByDescIntMethod = nums.Where(num => num < 9).OrderByDescending(num => num).ToList();

            List<Student> orderByDescObjQuery = (from stu in students
                                   orderby stu.Name descending
                                   select stu).ToList();

            List<Student> orderByDescObjMethod = students.OrderByDescending(stu => stu.Id).ToList();

            // ThenBy , ThenByDescending
            List<Student> thenByObjQuery = (from stu in students
                                  orderby stu.Id descending, stu.Name
                                  select stu).ToList();

            List<Student> thenByObjMethod = students.OrderByDescending(stu => stu.Name).ThenByDescending(stu => stu.Id).ToList();

            // Reverse
            // LINQ Reverse method works only on Enumerable or Queryable class
            // so we need to convert List<int> to Enumerable or Queryable
            List<int> reverseIntMethod = nums.AsEnumerable().Reverse().ToList();

            // no reverse in query syntax
            List<int> reverseIntQuery = (from num in nums
                                   select num).Reverse().ToList();
            

            Console.ReadLine();
        }

    }
}
