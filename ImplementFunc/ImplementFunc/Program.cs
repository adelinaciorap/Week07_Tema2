using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementFunc
{
    class Program
    {
        static int Sum(int x, int y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;
            int result = add(30, 23);
            Console.WriteLine(result);

            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 20);

            };

            Func<int> getRandomNumber1 = () => new Random().Next(2, 23);

            Func<int, int, int> Sum = (x, y) => x + y;

        }
    }
}
