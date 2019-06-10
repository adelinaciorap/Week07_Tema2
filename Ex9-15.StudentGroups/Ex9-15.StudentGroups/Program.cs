    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

namespace Ex9_15.StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {

            var students = new List<Student>();
            students.Add(new Student("Daniel", "Iacob", "01234", "0756343453", "dan@avg.bg", new List<int> { 8, 5, 8, 2 }, 2));
            students.Add(new Student("Paul", "Suciu", "07565", "0734545455", "paulsu@gmail.com", new List<int> { 8, 8, 9, 9 }, 1));
            students.Add(new Student("Ghita", "Muresan", "34455", "0733222204", "ghita@alaa.net", new List<int> { 2, 7, 2, 6 }, 1));
            students.Add(new Student("Vlad", "Nisora", "62134", "+32 725555800", "thevlad@avg.bg", new List<int> { 8, 6, 7, 10 }, 1));
            students.Add(new Student("Sergiu", "Plavan", "62134", "+40 72454560", "serge@yahoo.com", new List<int> { 8, 10, 10, 10 }, 2));

            Console.WriteLine("All students: ");
            Console.WriteLine(new string('-', 25));
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i]);
            }

            var studentsGroup2 = from student in students
                                 where student.GroupNumber == 2
                                 orderby student.FirstName
                                 select student;
            Console.WriteLine("LINQ students in group2 : ");

            foreach (var student in studentsGroup2)
            {
                Console.WriteLine(student);
            }

            studentsGroup2 = students.Where(student => student.GroupNumber == 2).OrderBy(student => student.FirstName);
            Console.WriteLine("LAMBDA students in group2 : ");

            foreach (var student in studentsGroup2)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" Extract students by email avg.bg");
            var studentsEmail = from student in students
                                where student.Email.Contains("avg.bg")
                                select student;

            foreach (var student in studentsEmail)
            {
                Console.WriteLine(student);
            }


            Console.WriteLine(" Extract students with phones in Sofia");
            var telSofia = from student in students
                           where student.Tel.StartsWith("073")
                           select student;

            foreach (var student in telSofia)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" Students with exeelent mark");
            var excelentMark = from student in students
                               where student.Marks.Contains(10)
                               select new { FullName = student.FirstName + " " + student.LastName, Marks = string.Join(", ", student.Marks) };
            foreach (var student in excelentMark)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(" Students with two marks 2");

            var studentsWith2Twos = students.Where(x => x.Marks.FindAll(y => y == 2).Count == 2).Select(x => new
            {
                FullName = x.FirstName + " " + x.LastName,
                MarksList = x.Marks
            });

            foreach (var student in studentsWith2Twos)
            {
                Console.WriteLine("Full name: {0}", student.FullName);
                Console.WriteLine("Marks: {0}", string.Join(", ", student.MarksList));
             
            }


        }
    }
}


