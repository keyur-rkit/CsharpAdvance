using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class SortingInLINQ
    {
        // Sorting operators : OrderBy , OrderBYDescending , ThenBy , ThenBYDescending , Reverse
    
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
            var orderByIntQuery = (from num in nums
                                  where num<9
                                  orderby num
                                  select num).ToList();

            var orderByIntMethod = nums.Where(num => num<9).OrderBy(num => num).ToList();

            var orderByObjQuery = (from stu in students
                                   orderby stu.Name
                                   select stu).ToList();

            var orderByObjMethod = students.OrderBy(stu => stu.Id).ToList();

            // OrderByDescending
            var orderByDescIntQuery = (from num in nums
                                       where num<9
                                       orderby num descending
                                       select num).ToList();

            var orderByDescIntMethod = nums.Where(num => num < 9).OrderByDescending(num => num).ToList();

            var orderByDescObjQuery = (from stu in students
                                   orderby stu.Name descending
                                   select stu).ToList();

            var orderByDescObjMethod = students.OrderByDescending(stu => stu.Id).ToList();

            // ThenBy , ThenByDescending
            var thenByObjQuery = (from stu in students
                                  orderby stu.Id descending, stu.Name
                                  select stu).ToList();

            var thenByObjMethod = students.OrderByDescending(stu => stu.Name).ThenByDescending(stu => stu.Id);

            // Reverse
            // LINQ Reverse method works only on Enumerable or Queryable class
            // so we need to convert List<int> to Enumerable or Queryable
            var reverseIntMethod = nums.AsEnumerable().Reverse().ToList();

            // no reverse in query syntax
            var reverseIntQuery = (from num in nums
                                   select num).Reverse().ToList();
            

            Console.ReadLine();
        }

    }
}
