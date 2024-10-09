
using System.Globalization;

namespace Assignment3
{
    internal class Array
    {
        public int[] numbers = new int[3];


        public int CalculateSum()
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public double CalculateAverage()
        {
            int sum = CalculateSum();
            return (double)sum / numbers.Length;
        }
    }
}
