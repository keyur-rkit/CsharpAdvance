using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesClass
{
    /// <summary>
    /// Partial class of Person
    /// </summary>
    public partial class Person
    {
        /// <summary>
        ///  Run Method
        /// </summary>
        public void Run()
        {
            Console.WriteLine("Run method called from partial class Person from Person1.cs");
        }
    }
}
