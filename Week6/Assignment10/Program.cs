using System.Globalization;

namespace Assignment10
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
            Console.Write("Enter scores separated by spaces: ");
            string input = Console.ReadLine();
            int[] scores = input.Split(' ').Select(int.Parse).ToArray();

            Student student = new Student(scores);

            Console.WriteLine("\nStudent details:");
            Console.WriteLine($"Average score; {student.AverageScore:0.00}");
        }
    }
}