using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.IEnumerable_extensions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[]somearay=new int[5];

            for(int i=0; i<somearay.Length; i++)
            {
                somearay[i]=i+1;

            }

            Console.WriteLine("Suma numerelor este: {0}", somearay.Sum<int>());
            Console.WriteLine("Produsul numerelor este: {0}", somearay.Product<int>());
            Console.WriteLine("Numarul minim este : {0}", somearay.Min <int>());
            Console.WriteLine("Numarul maxim este : {0}", somearay.Max <int>());
            Console.WriteLine("Media numnerelor este: {0}", somearay.Avrg<int>());

        }
    }
}
