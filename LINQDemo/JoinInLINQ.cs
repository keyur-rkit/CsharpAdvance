using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{

    class JoinInLINQ
    {
        class Student 
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int AddressId { get; set; }
        }

        class Address
        {
            public int Id { get; set; }
            public string AddressLine { get; set; }
        } 

        class Mark
        {
            public int StuID { get; set; }
            public int TotalMark { get; set; }
        }

        public static void RunJoinInLINQDemo()
        {
            // Join Operators : Inner JOIN , Group JOIN, Left JOIN

            List<Student> students = new List<Student> 
            { 
                new Student { Id = 1 , Name = "Keyur" , AddressId = 1 },
                new Student { Id = 2 , Name = "Hit"  },
                new Student { Id = 3 , Name = "Meet" , AddressId = 2 },
                new Student { Id = 4 , Name = "Vivek" , AddressId = 1 },
                new Student { Id = 5 , Name = "Drashti" , AddressId = 4 }
            };

            List<Address> addresses = new List<Address>
            {
                new Address { Id = 1 , AddressLine = "Line 1" },
                new Address { Id = 2 , AddressLine = "Line 2" },
                new Address { Id = 3 , AddressLine = "Line 3" }
            };

            List<Mark> marks = new List<Mark>
            {
                new Mark { StuID = 1 , TotalMark = 450},
                new Mark { StuID = 2 , TotalMark = 480},
                new Mark { StuID = 3 , TotalMark = 390}
            };

            // Inner JOIN of 2 tables
            var joinTwoQuery = (from stu in students
                               join add in addresses
                               on stu.AddressId equals add.Id
                               select new 
                               {
                                   stu.Id,
                                   stu.Name,
                                   add.AddressLine
                               }).ToList();

            var joinTwoMethod = students.Join(marks,
                                            stu => stu.Id , 
                                            mark => mark.StuID , 
                                            (stu, mark) => new 
                                            {
                                            stu.Id,
                                            stu.Name,
                                            mark.TotalMark
                                            }).ToList();

            // inner JOIN of 3 tables
            var joinThreeQuery = (from stu in students
                                join add in addresses
                                on stu.AddressId equals add.Id
                                join mark in marks
                                on stu.Id equals mark.StuID
                                select new
                                {
                                    stu.Id,
                                    stu.Name,
                                    add.AddressLine,
                                    mark.TotalMark
                                }).ToList();

            var joinThreeMethod = students.Join(marks,
                                            stu => stu.Id,
                                            mark => mark.StuID,
                                            (stu, mark) => new { stu, mark } )
                                            .Join(addresses,
                                            student => student.stu.AddressId,
                                            address => address.Id,
                                            (student , address) => new { student , address })
                                            .Select( x => new
                                            {
                                                StudentName = x.student.stu.Name,
                                                StudentAddress = x.address.AddressLine,
                                                StudentMark = x.student.mark.TotalMark
                                            })
                                            .ToList();
            // Performs a join between 'students', 'marks', and 'addresses' collections based on matching keys, 
            // and selects the student's name, address, and total marks into a new list of anonymous objects.


            // Group JOIN
            var groupJoinMethod = addresses.GroupJoin(students,
                                                        add=> add.Id, 
                                                        stu => stu.AddressId, 
                                                        (add,stu) => new 
                                                        { 
                                                            add, 
                                                            stu 
                                                        }).ToList();

            var groupJoinQuery = (from add in addresses
                                  join stu in students
                                  on add.Id equals stu.AddressId into AddressGroup
                                  select new { add, AddressGroup }).ToList();

            // Left JOIN
            var leftJoinQuery = (from stu in students
                                 join add in addresses
                                 on stu.AddressId equals add.Id into stuGroup
                                 from stuAddress in stuGroup.DefaultIfEmpty()
                                 select new {stu , stuAddress }).ToList();

            var leftJoinMethod = students.GroupJoin(addresses,
                                                    stu => stu.AddressId,
                                                    add => add.Id,
                                                    (stu,add) => new 
                                                    {
                                                        stu,
                                                        add
                                                    }).SelectMany(x => x.add.DefaultIfEmpty(), 
                                                    (stu,add)=> new 
                                                    { 
                                                        stu,
                                                        add
                                                    }).ToList();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
