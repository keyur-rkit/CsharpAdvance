using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesClass
{
    public partial class Person
    {
        public void Run()
        {
            Console.WriteLine("Run method called from partial class Person from Person2.cs");
        }
    }
}
