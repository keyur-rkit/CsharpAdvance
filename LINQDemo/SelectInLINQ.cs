using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// demo student class
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    /// <summary>
    /// demo employee class
    /// </summary>
    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
    }
    
    /// <summary>
    /// class to show select in LINQ
    /// </summary>
    public class SelectInLINQ
    {
        /// <summary>
        /// method to show Select in LINQ
        /// </summary>
        public static void RunSelectInLINQDemo()
        {

            // Projection operators : Select , SelectMany

            List<Student> students = new List<Student> 
            { 
                new Student{Id = 1,Name = "Keyur",Email = "keyur@gmail.com" },
                new Student{Id = 2,Name = "Hit",Email = "hit@gmail.com" },
                new Student{Id = 3,Name = "Vivek",Email = "vivek@gmail.com" },
                new Student{Id = 4,Name = "Drashti",Email = "drashti@gmail.com" },
                new Student{Id = 5,Name = "Meet",Email = "meet@gmail.com" }
            };

            Console.WriteLine("Query and method to select all :");

            List<Student> selectAllQuery = (from stu in students
                                 select stu).ToList();

            List<Student> selectAllMethod = students.ToList();

            Console.WriteLine("Query and method to select some value :");

            List<int> selectSomeQuery = (from stu in students
                                   select stu.Id).ToList();

            List<(int,string)> selectSomeMethod = students.Select(stu => (stu.Id,stu.Name)).ToList();

            Console.WriteLine("Query and Method to select Student objects to Employee :");

            List<Employee> selectToEmpQuery = (from stu in students
                                    select new Employee()
                                    {
                                        EmpId = stu.Id,
                                        EmpName = stu.Name,
                                        EmpEmail = stu.Email
                                    }).ToList();

            List<Employee> selectToEmpMethod = students.Select(stu => new Employee()
            {
                EmpId = stu.Id,
                EmpName = stu.Name,
                EmpEmail = stu.Email
            }).ToList();

            // SelectMany
            List<string> names = new List<string> { "Keyur", "Hit" };

            List<char> selectManyMethod = names.SelectMany(n => n).ToList();

            List<char> selectManyQuery = (from name in names
                                   from ch in name
                                   select ch).ToList();

            foreach (Student student in selectAllQuery)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
