
namespace Assignment5
{
    internal class Person
    {
        public string name;
        public int age;


        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }


        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }

        public void PrintPersonArray(Person[] persons)
        {
            for (int i = 0; i < persons.Length; i++)
            {
                Console.WriteLine($"Person {i + 1}: ");
                persons[i].DisplayPersonInfo();
                Console.WriteLine();
            }
        }
    }
}