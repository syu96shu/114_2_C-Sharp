namespace 員工資料管理系統
{
    public class Employee
    {
        public string Name { get; set; }
        public int IdNumber { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }

        public Employee()
        {
            IdNumber = 0;
            Name = "";
            Department = "";
            Position = "";
        }

        public Employee(int idNumber, string name)
        {
            IdNumber = idNumber;
            Name = name;
            Department = "";
            Position = "";
        }

        public Employee(int idNumber, string name, string department, string position)
        {
            IdNumber = idNumber;
            Name = name;
            Department = department;
            Position = position;
        }

        public override string ToString()
        {
            return IdNumber + "\t" + Name;
        }
    }
}
