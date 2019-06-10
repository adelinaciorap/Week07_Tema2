using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4.AgeRange
{
    class Program
    {
        static void Main(string[] args)
        {
            Students []students  =
            {
                 new Students("Ana", "Dobre", 23),
                 new Students("Petru", "Movila", 21),
                 new Students ("Gica", "Petrescu", 32),
                 new Students ("Andrei", "Bostan", 24),
                 new Students("Raluca", "Marian", 19),
                 new Students("Carmen", "Lupu", 23),
                 new Students("Andreaa", "Papuc", 30),

            };

            var ageRangeStudents= from student in students
                                  where(student.Age >= 18) && (student.Age <= 24)
                                  select student;

            foreach(Students student in ageRangeStudents)
            {
                Console. WriteLine(student);
            }


                
        }

    }
}
