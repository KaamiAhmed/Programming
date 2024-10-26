
using static System.Formats.Asn1.AsnWriter;

namespace Assignment10
{
    internal class Student
    {
        private int[] _scores;
        private double _averageGrade;


        public Student(int[] scores)
        {
            _scores = scores;
        }

        public int[] Scores
        {
            get
            {
                return _scores;
            }
        }


        public double AverageScore
        {
            get
            {
                return Scores.Average();
            }
        }
    }
}
