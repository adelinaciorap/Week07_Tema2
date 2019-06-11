using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16.Groups
{
    class Program
    {  
        static void Main(string[] args)
        {
            var students = new List<Student>();
            students.Add(new Student("Daniel", "Iacob", "01234", "0756343453", "dan@avg.bg", new List<int> { 8, 5, 8, 2 }, 2, new Group(2, "Computing")));
            students.Add(new Student("Paul", "Suciu", "075650", "0734545455", "paulsu@gmail.com", new List<int> { 8, 8, 9, 9 }, 1, new Group(4, "Math")));
            students.Add(new Student("Ghita", "Muresan", "344466", "0733222204", "ghita@alaa.net", new List<int> { 2, 7, 2, 6 }, 1, new Group(3, "Music")));
            students.Add(new Student("Vlad", "Nisora", "621366", "+32 725555800", "thevlad@avg.bg", new List<int> { 8, 6, 7, 10 }, 1, new Group(2, "Math")));
            students.Add(new Student("Sergiu", "Plavan", "62134", "+40 72454560", "serge@yahoo.com", new List<int> { 8, 10, 10, 10 }, 2, new Group(1, "Economy")));

            var studentsMath =
                from student in students
                where student.GroupNumber.DepartamentName == "Math"
                select student;

            Console.WriteLine("Stutents from mathematics department: ");
            foreach(var student in studentsMath)
            {
                Console.WriteLine(student);
            }
        }

    }
    
    
}
