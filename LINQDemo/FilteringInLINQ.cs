using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    class FilteringInLINQ
    {
        public static void FilteringInLINQDemo()
        {
            // Filtering operators : Where , OfType 

            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10};

            var whereQuery = (from num in numbers
                             where num <=5 || num >9
                             select num).ToList();

            var whereMethod = numbers.Where(num => num <=9 && num>=5).ToList();

            List<string> names = new List<string> { "Keyur", "Meet", " Vivek", " Hit", "Drashti"};

            var whereStringQuery = (from name in names
                                    where name == "Hit" || name.Length > 5 
                                    select name).ToList();

            var whereStringMethod = names.Where(name => name == "Hit" || name.Length > 5).ToList();

            List<object> data = new List<object> { "Keyur", "Meet", " Vivek", " Hit",1,2,3,4 };

            var whereObjectQuery = (from obj in data
                                    where obj is string
                                    select obj).ToList();

            var whereObjectMethod = data.OfType<string>().ToList();

            Console.ReadLine();
        }
    }
}
