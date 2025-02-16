using System.Globalization;

namespace SumNumbers
{
    public class SumNumbers
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            Console.WriteLine(NumbersCount(numbers));
            Console.WriteLine(NumbersSum(numbers));

        }
        static int NumbersCount(int[] numbers)
        {
            int count = 0;
            foreach (var item in numbers)
            {
                count++;
            }
            return count;
        }

        static int NumbersSum(int[] numbers)
        {
            int sum = 0;
            foreach (var item in numbers)
            {
                sum += item;
            }
            return sum;
        }
    }
}