﻿using System.Threading.Channels;
using System.Transactions;

namespace Assignment7
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
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();
            Console.Write("Enter amount of grades to process: ");
            int amountOfGrades = int.Parse(Console.ReadLine());
            
            int[] grades = new int[amountOfGrades];

            for (int i = 0; i < amountOfGrades; i++)
            {
                Console.Write($"Enter grade {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }

            Student student = new Student(name, grades);

            Console.WriteLine($"Grades for {name}:");
            student.DisplayGrades();

            double average = student.CalculateAverage();
            Console.WriteLine($"\nAverage Grades: {average:0.00}");
        }
    }
}
