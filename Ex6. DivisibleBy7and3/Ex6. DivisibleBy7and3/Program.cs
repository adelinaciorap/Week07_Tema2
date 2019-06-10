using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.DivisibleBy7and3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 5, 3, 21, 8, 6, 441, 63, 56 };

            Console.WriteLine("Lambda");
            var divisibleNumbers = array.Where(num => num % 3 == 0 && num % 7 == 0);
            Console.WriteLine(string.Join(",", divisibleNumbers));

            Console.WriteLine("Linq");
            divisibleNumbers = from num in array
                               where num % 3 == 0 && num % 7 == 0
                               select num;

            Console.WriteLine(string.Join(",", divisibleNumbers));
        }
    }
}
