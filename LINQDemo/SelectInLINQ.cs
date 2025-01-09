using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpEmail { get; set; }
    }
    
    class SelectInLINQ
    {
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

            var selectAllQuery = (from stu in students
                                 select stu).ToList();

            var selectAllMethod = students.ToList();

            Console.WriteLine("Query and method to select some value :");

            var selectSomeQuery = (from stu in students
                                   select stu.Id).ToList();

            var selectSomeMethod = students.Select(stu => (stu.Id,stu.Name)).ToList();

            Console.WriteLine("Query and Method to select Student objects to Employee :");

            var selectToEmpQuery = (from stu in students
                                    select new Employee()
                                    {
                                        EmpId = stu.Id,
                                        EmpName = stu.Name,
                                        EmpEmail = stu.Email
                                    }).ToList();

            var selectToEmpMethod = students.Select(stu => new Employee()
            {
                EmpId = stu.Id,
                EmpName = stu.Name,
                EmpEmail = stu.Email
            }).ToList();

            // SelectMany
            List<string> names = new List<string> { "Keyur", "Hit" };

            var selectManyMethod = names.Select(n => n).ToList();

            var selectManyQuery = (from name in names
                                   from ch in name
                                   select ch).ToList();

            foreach (var student in selectAllQuery)
            {
                Console.WriteLine(student.Name);
            }
        }
    }
}
