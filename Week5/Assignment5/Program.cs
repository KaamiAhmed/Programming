using System.Xml.Linq;

namespace Assignment5
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
            Person[] persons = new Person[3];

            for (int i = 0; i < persons.Length; i++)
            {
                Console.Write($"Enter a name for person {i + 1}: ");
                string name = Console.ReadLine();
                Console.Write($"Enter age for person {i + 1}: ");
                int age = int.Parse(Console.ReadLine());

                persons[i] = new Person(name, age);

                Console.WriteLine();
            }

            Console.WriteLine("\nDisplaying all persons:");
            persons[0].PrintPersonArray(persons);

        }
    }
}