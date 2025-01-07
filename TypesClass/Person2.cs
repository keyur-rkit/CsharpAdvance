using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesClass
{
    public partial class Person
    {
        public void Walk()
        {
            Console.WriteLine("Walk method called from partial class Person from file Person2.cs");
        }
    }
}
