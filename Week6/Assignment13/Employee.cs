
namespace Assignment13
{
    internal class Employee
    {
        private string _name;
        private double _salary;

        public Employee(string name, double salary)
        {
            _name = name;
            _salary = salary;
        }

        public string Name { get { return _name; } set { _name = value; } }
        public double Salary { get { return _salary; } set { _salary = value; } }

        public double Bonus
        {
            get
            {
                return 5000;
            }
        }
    }
}
