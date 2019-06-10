using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Ex3.FirstBeforeLast
{
    class Program
    {
        static void Main(string[] args)
        {

            var students= new[]
            {
            new {FirstName = "Ana", LastName="Dobre"},
            new {FirstName = "Petru", LastName = "Movila"},
            new {FirstName = "Gica", LastName = "Petrescu"},
            new {FirstName = "Andrei", LastName = "Bostan"},
            new {FirstName = "Raluca", LastName = "Marian"},
            new {FirstName = "Carmen", LastName = "Lupu"},
            new {FirstName = "Andreaa", LastName = "Papuc"},

            };   

            Console.WriteLine("Listing students with first name before last name:");
            
            var sortingByFirstName= from student in students 
                                    where student.FirstName.CompareTo(student.LastName) == -1
                                    select(student.FirstName + " " + student.LastName);
            
            foreach(var stud in sortingByFirstName)
            {
                Console.WriteLine(stud);
            }
        }
    }
}
