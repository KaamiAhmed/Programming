using System.Globalization;

namespace Assignment3
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
            //int[] numbers = new int[3];
            Array integers = new Array();
            Console.WriteLine("Enter 3 integers: ");
            for (int i = 0; i < integers.numbers.Length; i++)
            {
                integers.numbers[i] = int.Parse(Console.ReadLine());
            }

            

            int sum = integers.CalculateSum();
            double average = integers.CalculateAverage(); 

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average:0.00}");
        }
    }
}