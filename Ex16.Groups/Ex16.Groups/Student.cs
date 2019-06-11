using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16.Groups
{
    public class Student
    {
        public Student(string firstName, string lastName, string fn, string tel, string email, List<int> marks, int groupNumber, Group group)
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
