using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5.OrderStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students =
                 {
                 new Student("Ana", "Dobre"),
                 new Student("Petru", "Movila"),
                 new Student ("Gica", "Petrescu"),
                 new Student ("Andrei", "Bostan"),
                 new Student("Raluca", "Marian"),
                 new Student("Carmen", "Lupu"),
                 new Student("Andreaa", "Papuc"),

            };


            //Lambda sorting
            var orderedStudents =
               students.OrderByDescending(student => student.FirstName).
               ThenByDescending(student => student.LastName);

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();

            //sorting with LINQ
            orderedStudents =
                from student in students
                orderby student.FirstName descending, student.LastName descending
                select student;

            foreach (var student in orderedStudents)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine();
        }
    }
}
    


