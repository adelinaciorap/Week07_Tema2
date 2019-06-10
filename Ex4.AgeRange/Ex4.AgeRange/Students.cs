namespace Ex4.AgeRange
{
    public class Students
    {
        
        public Students(string firstname, string lastname, int age)
        {
            this.FirstName = firstname;
            this.LastNAme = lastname;
            this.Age = age;
        }

        public string FirstName { get; set; }
        public string LastNAme { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string output = string.Format("Student: {0} {1} {2}", this.FirstName, this.LastNAme, this.Age);
            return output.ToString();
        }
    }
}
