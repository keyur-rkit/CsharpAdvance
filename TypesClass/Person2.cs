using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesClass
{
    /// <summary>
    /// Partial class peson
    /// </summary>
    public partial class Person
    {
        /// <summary>
        /// Method Walk
        /// </summary>
        public void Walk()
        {
            Console.WriteLine("Walk method called from partial class Person from file Person2.cs");
        }
    }
}
