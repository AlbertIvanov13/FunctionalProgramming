namespace _13._ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endOfRange = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            List<int> newNumbers = new List<int>();

            for (int i = 1; i <= endOfRange; i++)
            {
                numbers.Add(i);
            }

            HashSet<int> dividers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToHashSet();

            int counter = 0;

            Predicate<int> isDivisible = num =>
            {
                counter = 0;
                foreach (var item in dividers)
                {
                    if (num % item == 0)
                    {
                        counter++;
                        if (counter == dividers.Count)
                        {
                           return num % item == 0;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
                return default;
            };

            Func<int[], int[]> divisibleNumbers = nums =>
            {
                foreach (int num in nums)
                {
                    if (isDivisible(num))
                    {
                        newNumbers.Add(num);
                    }
                }

                return newNumbers.ToArray();
            };

            Console.WriteLine(string.Join(" ", divisibleNumbers(numbers.ToArray())));
        }
    }
}