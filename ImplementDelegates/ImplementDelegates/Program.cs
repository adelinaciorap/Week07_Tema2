using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementDelegates
{
    class Program
    {
        public delegate void Print(int number);

        static void Main(string[] args)
        {
            Print someNum = PrintNumber;

            someNum += PrintHexadecimal;
            someNum += PrintMoney;
            someNum(10000);

            someNum -= PrintHexadecimal;
            someNum(15000);
            //Print someNum = new Print(PrintNumber);
            someNum(579);
            someNum(1000);
            someNum.Invoke(2000);

            someNum = PrintMoney;
            someNum(300);
            someNum(500);

            PrintHelper(PrintNumber, 1500);
            PrintHelper(PrintMoney, 2500);


        }

        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money:{0:C}", money);
        }

        public static void PrintHelper(Print delegateFunc, int numToPrint)
        {
            delegateFunc(numToPrint);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal:{0:X}", dec);
        }
    }
}
