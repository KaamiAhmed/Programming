namespace Assignment13
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
            Console.Write("Enter employee name: ");
            string name = Console.ReadLine();
            Console.Write("Enter salary: ");
            double salary = double.Parse(Console.ReadLine());

            Employee employee = new Employee(name, salary);

            Console.WriteLine("\nEmployee details:");
            Console.WriteLine($"Name: {employee.Name}");
            Console.WriteLine($"Salary: {employee.Salary}");
            Console.WriteLine($"Bonus: {employee.Bonus}");
        }
    }
}
