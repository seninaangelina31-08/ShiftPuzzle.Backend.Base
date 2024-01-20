namespace PracticeC
{
    [System.Serializable] public class Company
    {
        public string companyName { get; set; }
        public List<Employee> employees { get; set; }
        public Location location { get; set; }

        public Company() { }

        public Company(string CompanyName, List<Employee> Employees, Location LOcation)
        {
            this.companyName = CompanyName;
            this.employees = Employees;
            this.location = LOcation;
        }
    }

    [System.Serializable] public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string position { get; set; }
        public List<string> skills { get; set; }
        public int salary { get; set; }
        
        public Employee() { }

        public Employee(int Id, string Name, string Position, List<string> Skills, int Salary)
        {
            this.id = Id;
            this.name = Name;
            this.position = Position;
            this.skills = Skills;
            this.salary = Salary;
        }

    }

    [System.Serializable] public class Location
    {
        public string city { get; set; }
        public string address { get; set; }

        public Location() { }

        public Location(string City, string Address)
        {
            this.city = City;
            this.address = Address;
        }
    }

    [System.Serializable] public class CountEmployees
    {
        public int directors { get; set; }
        public int accountants { get; set; }
        public int programmers { get; set; }

        public CountEmployees() { }

        public CountEmployees(int Directors, int Accountants, int Programmers)
        {
            this.directors = Directors;
            this.accountants = Accountants;
            this.programmers = Programmers;
        }

    }
}