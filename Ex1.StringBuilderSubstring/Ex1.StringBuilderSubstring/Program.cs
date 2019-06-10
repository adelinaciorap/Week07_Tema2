using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.StringBuilderSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = new StringBuilder();
            text.Append("This is for testing");
            Console.WriteLine(text);
            text = text.Substring(6, 11);
            Console.WriteLine(text);
        }
    }
}
