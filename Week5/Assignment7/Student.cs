
namespace Assignment7
{
    internal class Student
    {
        //fields
        public string name;
        public int[] grades;

        //constructor
        public Student(string name, int[] grades)
        {
            this.name = name;
            this.grades = grades;
        }

        public double CalculateAverage()
        {
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                sum += grades[i];
            }
            return sum / grades.Length;
        }

        public void DisplayGrades()
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"{grades[i]}, ");
            }
        }
    }
}
