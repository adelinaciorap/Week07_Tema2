using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementLINQ
{
    class Program
    {
        delegate bool IsTeenager(Student stud);

        delegate bool isYoungerThan(Student stud, int youngAge);
        delegate bool isAdult(Student s);

        delegate void Print();

        static void Main(string[] args)

        {// IsTeenager checkAge = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

            IsTeenager checkIfTeenager = s => s.Age > 12 && s.Age < 20;

            isYoungerThan checkIfYounger = (s, youngAge) => s.Age < youngAge;

            isYoungerThan isYounger = (s, youngAge) =>
              {
                  Console.WriteLine("Lamba expression with multiple statemnt in the body");
                  return s.Age < youngAge;
              };

            isAdult checkIfAdult = (s) =>
             {
                 int adultAge = 18;
                 Console.WriteLine("Lambda expression with multiple statements in the body");
                 return s.Age >= adultAge;

             };

            Student stud1 = new Student() { Age = 23 };
            Console.WriteLine(checkIfTeenager(stud1));
            Console.WriteLine(checkIfYounger(stud1, 26));
            Console.WriteLine(isYounger(stud1, 21));
            Console.WriteLine(checkIfAdult(stud1));


            Print print = () => Console.WriteLine("Thi is a parametr less lambda");
            print();

            Func<Student, bool> isStudentTeen = s => s.Age > 12 && s.Age < 20;
            Student stud = new Student() { Age = 21 };

            Console.WriteLine(isStudentTeen(stud));

            Action<Student> PrintStudentDetails =s => Console.WriteLine("Name: {0}, Age: {1} ", s.Name, s.Age);
            Student std = new Student() { Name = "Bill", Age = 45 };
            PrintStudentDetails(std);

            //Student collection
            IList<Student> stdLits = new List<Student>()
            {
                new Student(){Id=1, Name="IOn1", Age=11},
                new Student(){Id=2, Name="IOn2", Age=17},
                new Student(){Id=5, Name="IOn3", Age=19},
                new Student(){Id=9, Name="IOn5", Age=24},
                new Student(){Id=7, Name="IOn7", Age=18},
            };
            Func<Student, bool> isStudentTeener = s => s.Age > 12 && s.Age < 20;
            var teenager = stdLits.Where(isStudentTeen);
            Console.WriteLine("teen age students:");
            foreach(Student stds in teenager)
            {
                Console.WriteLine(stds.Name);
            }


            Func<Student, bool> isStudentATeen = s => s.Age > 12 && s.Age < 21;
            var teenStudents = from s in stdLits
                               where isStudentATeen(s)
                               select s;
            Console.WriteLine("teen age students2:");
            foreach (Student stdss in teenStudents)
            {
                Console.WriteLine(stdss.Name);
            }
        }

        public class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }



        }
    }
}
