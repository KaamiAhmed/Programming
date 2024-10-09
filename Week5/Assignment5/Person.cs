
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

    }
}