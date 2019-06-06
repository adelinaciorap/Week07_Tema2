using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementPredicate
{
    class Program

    {
        static bool IsUpperCase(string atr)
        {
            return atr.Equals(atr.ToLower());
        }

        static void Main(string[] args)
        {
            Predicate<string> UpperChecker = IsUpperCase;
            bool result = UpperChecker("NO YELLING!");
            Console.WriteLine(result);

            Predicate<string> isUpper1 = delegate (string s) { return s.Equals(s.ToUpper()); };
            bool result1 = isUpper1("hello goodbYe");
            Console.WriteLine(result1);

            Predicate<string> IsLower = s => s.Equals(s.ToLower());
            bool result2 = IsLower("hello world");
            Console.WriteLine(result2);
        }
    }
}
