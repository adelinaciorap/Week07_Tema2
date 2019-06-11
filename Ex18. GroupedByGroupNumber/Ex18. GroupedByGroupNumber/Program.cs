using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18.GroupedByGroupNumber
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>
            {
            new Student("Oana MArcu",123),
            new Student("David IOn", 214),
            new Student("Maria Ioana", 456),
            new Student("Gelu grosu", 123),
            new Student("Ina Manole", 214),
            new Student("Tania Bidu", 456),
            };

            var groupsStudents = students.OrderBy(x => x.GroupName);

            foreach(var student in groupsStudents)
            {
                Console.WriteLine(student.ToString());
            }
        }
    }
}
