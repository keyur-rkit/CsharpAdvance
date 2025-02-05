using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    /// demo person class with Custom equality comparer
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        /// <summary>
        /// Custom equality comparer class
        /// </summary>
        public class PersonComparer : IEqualityComparer<Person>
        {
            /// <summary>
            /// Custom equality comparer method Equals
            /// </summary>
            /// <param name="x"></param>
            /// <param name="y"></param>
            /// <returns></returns>
            public bool Equals(Person x, Person y)
            {
                if (x == null || y == null) return false;
                return x.Name == y.Name && x.Age == y.Age;
            }

            /// <summary>
            /// Custom equality comparer method for GetHashCode
            /// </summary>
            /// <param name="obj"></param>
            /// <returns></returns>
            public int GetHashCode(Person obj)
            {
                if (obj == null) return 0;
                return obj.Name.GetHashCode() ^ obj.Age.GetHashCode();
            }
        }
    }

    /// <summary>
    /// Class to show Quantifier In LINQ
    /// </summary>
    public class QuantifierInLINQ
    {
        /// <summary>
        /// Method for QuantifierInLINQ
        /// </summary>
        public static void RunQuantifierInLINQDemo()
        {
            // Quantifier Operators : All , Any, Contains

            List<Student> students = new List<Student>
            {
                new Student{Id = 1,Name = "Keyur",Email = "keyur@gmail.com" },
                new Student{Id = 2,Name = "Hit",Email = "hit@gmail.com" },
                new Student{Id = 3,Name = "Vivek",Email = "vivek@gmail.com" },
                new Student{Id = 4,Name = "Drashti",Email = "drashti@gmail.com" },
                new Student{Id = 5,Name = "Meet",Email = "meet@gmail.com" }
            };

            List<string> names = new List<string> { "Keyur", "Meet", " Vivek", " Hit", "Drashti" };

            // All (only in method syntax)
            bool allHaveEmail = students.All(stu => stu.Email != null);

            // Any (only in method syntax)
            bool anyIsHit = students.Any(stu => stu.Name == "Hit");

            // Contains (only in method syntax)
            // LINQ Contains method works only on Enumerable or Queryable class
            // so we need to Contains List<string> to Enumerable or Queryable
            bool isExist = names.AsEnumerable().Contains("Keyur");



            // List of people
            List<Person> people = new List<Person>
                {
                    new Person { Name = "Keyur", Age = 21 },
                    new Person { Name = "Parth", Age = 22 },
                    new Person { Name = "Hit", Age = 20 }
                };

            Person.PersonComparer comparer = new Person.PersonComparer();

            // Using Contains with custom comparer
            bool isPersonExists = people.Contains(new Person { Name = "Keyur", Age = 21 }, comparer);

            Console.ReadLine();
        }
    }
}
