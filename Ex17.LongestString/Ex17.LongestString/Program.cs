using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex17.LongestString
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] textList =
            {
                "Lorem ",
                "ipsum dolor",
                "sit amet",
                "idque dicunt per te",
                "Mea eu contentiones",
                "signiferumque",
            };

            var stringnSort = from strings in textList
                              orderby strings.Length descending
                              select strings;

            string longestString = stringnSort.FirstOrDefault();

            Console.WriteLine("The longest string is: {0}", longestString);

        }
    }
}
