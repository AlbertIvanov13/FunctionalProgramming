namespace _11._ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> divideCheck = n => n % divisor == 0;

            Func<int[], int[]> function = nums =>
            {
                List<int> nonDivisibleNumbers = new List<int>();
                List<int> newNums = nums.ToList();
                for (int i = (nums.Length) - (1); i >= 0; i--)
                {
                    if (divideCheck(nums[i]))
                    {
                        newNums.Remove(nums[i]);
                    }
                    else
                    {
                        nonDivisibleNumbers.Add(nums[i]);
                    }
                }

                return nonDivisibleNumbers.ToArray();
            };

            Console.WriteLine(string.Join(" ", function(numbers)));
        }
    }
}