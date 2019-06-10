using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1.StringBuilderSubstring
{
    public static class StringBuilderExtension
    {
        public static StringBuilder Substring(this StringBuilder builder, int index, int lenght)
        {
            if (index < 0 || index >= builder.Length)
            {
                throw new IndexOutOfRangeException("Index is out of the range");
            }

            if (lenght < 0 || lenght > builder.Length - index)
            {
                throw new ArgumentOutOfRangeException("Invalid lenght");
            }

            StringBuilder result = new StringBuilder();

            for (int i = index; i < index + lenght; i++)
            {
                result.Append(builder[i]);

            }

            return result;
        }

    }
}
