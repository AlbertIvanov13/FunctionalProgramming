namespace _09._FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ranges = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int lowerRange = ranges[0];
            int upperRange = ranges[1];
            HashSet<int> numbers = new HashSet<int>();

            string command = Console.ReadLine();

            Predicate<int> check = n => n % 2 == 0;

            for (int i = lowerRange; i <= upperRange; i++)
            {
                if (command == "even")
                {
                    if (check(i))
                    {
                        numbers.Add(i);
                    }
                }
                else
                {
                    if (!check(i))
                    {
                        numbers.Add(i);
                    }
                }
            }

            Console.WriteLine($"{string.Join(" ", numbers)}");
        }
    }
}