using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementActionDelegate
{
    class Program
    {

        static void ConsolePrint(int b)
        {
            Console.WriteLine(b);
        }

        static void Main(string[] args)

        {
            Action<int> printActionDel = ConsolePrint;
            printActionDel(124);

            Action<int> printActionDel1 = ConsolePrint;

            Action<int> printActionDel3 = delegate (int i)
            {
                Console.WriteLine(i);
            };
            printActionDel3(45);


            Action<int> printActionDel4 = i => Console.WriteLine(i);
            printActionDel4(56);




        }
    }
}
