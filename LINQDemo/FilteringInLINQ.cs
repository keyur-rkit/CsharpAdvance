using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    /// <summary>
    ///  Class to show Filtering Demo
    /// </summary>
    public class FilteringInLINQ
    {
        /// <summary>
        /// Method to show Filtering
        /// </summary>
        public static void FilteringInLINQDemo()
        {
            // Filtering operators : Where , OfType 

            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            List<int> whereQuery = (from num in numbers
                             where num <=5 || num >9
                             select num).ToList();

            List<int> whereMethod = numbers.Where(num => num <=9 && num>=5).ToList();

            List<string> names = new List<string> { "Keyur", "Meet", " Vivek", " Hit", "Drashti"};

            List<string> whereStringQuery = (from name in names
                                    where name == "Hit" || name.Length > 5 
                                    select name).ToList();

            List<string> whereStringMethod = names.Where(name => name == "Hit" || name.Length > 5).ToList();

            List<object> data = new List<object> { "Keyur", "Meet", " Vivek", " Hit",1,2,3,4 };

            List<object> whereObjectQuery = (from obj in data
                                    where obj is string
                                    select obj).ToList();

            List<string> whereObjectMethod = data.OfType<string>().ToList();

            Console.ReadLine();
        }
    }
}
