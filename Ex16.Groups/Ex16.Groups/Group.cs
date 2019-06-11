namespace Ex16.Groups
{
    public class Group
    {
        public Group(int number, string department)
        {
            this.GroupNumber = number;
            this.DepartamentName = department;
        }

        public int GroupNumber { get; set; }
        public string DepartamentName { get; set; }


    }
}
