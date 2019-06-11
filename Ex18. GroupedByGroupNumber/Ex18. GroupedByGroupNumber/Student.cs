using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex18.GroupedByGroupNumber
{
    public class Student
    { public Student(string name, int group)
        {
            this.FullName = name;
            this.GroupName = group;
        }

        public string FullName { get; set; }
        public int GroupName{ get; set; }

        public override string ToString()
        {
            return this.FullName + " " + this.GroupName;
        }


    }
}
