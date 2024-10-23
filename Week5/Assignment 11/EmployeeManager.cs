
namespace Assignment_11
{
    internal class EmployeeManager
    {
        public Employee[] Employees;
        public int EmployeeCounter;


        public EmployeeManager(int capacity)
        {
            Employees = new Employee[capacity];
            EmployeeCounter = 0;
        }

        public void AddEmployee(Employee employee)
        {
            Employees[EmployeeCounter] = employee;
            EmployeeCounter++;
            Console.WriteLine("\nEmployee added.");
        }

        public void CalculateAverageSalary()
        {
            double sum = 0;
            for (int i = 0; i < Employees.Length; i++)
            {
                sum += Employees[i].Salary;
            }
            double average = (double)sum / Employees.Length;
            Console.WriteLine($"\nAverage Salary: {average:0.00}");
        }

        public void DisplayEmployees()
        {
            for (int i = 0; i < Employees.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Name: {Employees[i].Name}");
                Console.WriteLine($"ID: {Employees[i].Id}");
                Console.WriteLine($"Salary: {Employees[i].Salary}");
            }
        }
    }
}
