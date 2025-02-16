namespace _07._KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split().ToArray();

            PrintNames(names, n => Console.WriteLine(n));

        }

        public static void PrintNames(string[] names, Action<string> action)
        {
            foreach (var name in names)
            {
                action($"Sir {name}");
            }
        }
    }
}