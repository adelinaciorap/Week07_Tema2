using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5.OrderStudents
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int age;

        public Student(string firstname, string lastname)
        {

            this.FirstName = firstname;
            this.LastNAme = lastname;
          
        }

        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        

        public override string ToString()
        {
            string output = string.Format("Student: {0} {1} ", this.FirstName, this.LastNAme);
            return output.ToString();
        }
    }
}
    


