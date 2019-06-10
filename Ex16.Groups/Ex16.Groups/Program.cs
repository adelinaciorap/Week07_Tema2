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
            var students = new List<Student2>();
            students.Add(new Student2("Daniel", "Iacob", "01234", "0756343453", "dan@avg.bg", new List<int> { 8, 5, 8, 2 }, 2, new Group(2, "Computing")));
            students.Add(new Student2("Paul", "Suciu", "075650", "0734545455", "paulsu@gmail.com", new List<int> { 8, 8, 9, 9 }, 1, new Group(4, "Math")));
            students.Add(new Student2("Ghita", "Muresan", "344466", "0733222204", "ghita@alaa.net", new List<int> { 2, 7, 2, 6 }, 1, new Group(3, "Music")));
            students.Add(new Student2("Vlad", "Nisora", "621366", "+32 725555800", "thevlad@avg.bg", new List<int> { 8, 6, 7, 10 }, 1, new Group(2, "Math")));
            students.Add(new Student2("Sergiu", "Plavan", "62134", "+40 72454560", "serge@yahoo.com", new List<int> { 8, 10, 10, 10 }, 2, new Group(1, "Economy")));

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

    


    public class Student2
    {
        public Student2(string firstName, string lastName, string fn, string tel, string email, List<int> marks, int groupNumber, Group group)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FN = fn;
            this.Email = email;
            this.Tel = tel;
            this.Marks = marks;
            this.GroupNumber = group;

        }


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FN { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public List<int> Marks { get; set; }
        public Group GroupNumber { get; set; }


        public override string ToString()
        {
            StringBuilder data = new StringBuilder();
            data.AppendFormat("Name: {0} {1}\n", this.FirstName, this.LastName);
            data.AppendFormat("Faculty number {0}\n", this.FN);
            
            data.AppendFormat("Group number: {0}\n", this.GroupNumber);
            data.AppendFormat("Telephonne number{0}\n", this.Tel);
            data.AppendFormat("email address:{0}\n", this.Email);
            data.AppendFormat("Marks:{0}\n", string.Join(", ", Marks));
            
            return data.ToString();
        }
    }
}
