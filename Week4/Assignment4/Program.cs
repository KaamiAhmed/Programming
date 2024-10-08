namespace Assignment4
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
            string courseName;
            int nrOfStudents;

            Console.Write("Enter course name: ");
            courseName = Console.ReadLine();

            Console.Write("Enter number of students: ");
            nrOfStudents = int.Parse(Console.ReadLine());

            string[] names = new string[nrOfStudents];
            int[] grades = new int[nrOfStudents];

            ReadNames(names);
            ReadGrades(grades);

            int highestGradeIndex = GetHighestGradeIndex(grades);

            Console.WriteLine($"Student {names[highestGradeIndex]} has the highest grade: {grades[highestGradeIndex]}");
        }

        void ReadNames(string[] names)
        {
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter the name of student {i + 1}: ");
                names[i] = Console.ReadLine();
            }

        }

        void ReadGrades(int[] grades)
        {
            for (int i = 0; i < grades.Length; i++)
            {
                Console.Write($"Enter grades of student {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
            }
        }

        int GetHighestGradeIndex(int[] grades)
        {
            int highestIndex = 0;
            for(int i = 0; i < grades.Length; i++)
            {
                if (grades[i] > grades[highestIndex])
                {
                    highestIndex = i;
                }
            }
            return highestIndex;
        }
    }
}
