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
           Student [] students=
                {
                 new Student("Ana", "Dobre", 23),
                 new Student("Petru", "Movila", 21),
                 new Student ("Gica", "Petrescu", 32),
                 new Student ("Andrei", "Bostan", 24),
                 new Student("Raluca", "Marian", 19),
                 new Student("Carmen", "Lupu", 23),
                 new Student("Andreaa", "Papuc", 30),
                 
            };
           

            //Lambda sorting

            Console.WriteLine("Lambda sorting:");

            var orderStudents =
                student.OrderByDescending(student => student.FirstName).ThenByDescending(students.LastName);

            foreach(var student in orderStudents)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine("LINQ sorting:");

            var orderStudents2 = from student in students
                                orderby student.FirstName descending, student.LastName descending
                                select student;

            foreach(var student in orderStudents2)
            {
                Console.WriteLine(student);
            }
        }
    }
}
    


