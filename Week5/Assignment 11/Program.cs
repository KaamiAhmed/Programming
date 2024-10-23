namespace Assignment_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Start();
        }

        void Start()
        {
            const int NrOfEmployees = 3;
            EmployeeManager employeemanager = new EmployeeManager(NrOfEmployees);

            for (int i = 0; i < NrOfEmployees; i++)
            {
                Console.Write("Enter employee name: ");
                string name = Console.ReadLine();
                Console.Write("Enter employee id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter employee salary: ");
                double salary = double.Parse(Console.ReadLine());

                Employee employee = new Employee(name, id, salary);
                employeemanager.AddEmployee(employee);

                Console.WriteLine();
            }

            employeemanager.DisplayEmployees();
            employeemanager.CalculateAverageSalary();
        }
    }
}
