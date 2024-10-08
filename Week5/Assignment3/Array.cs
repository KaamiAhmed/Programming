
using System.Globalization;

namespace Assignment3
{
    internal class Array
    {
        public int[] numbers = new int[3];


        public int CalculateSum(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public double CalculateAverage(int[] numbers)
        {
            int sum = CalculateSum(numbers);
            return (double)sum / numbers.Length;
        }
    }
}
