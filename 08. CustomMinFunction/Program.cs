namespace _08._CustomMinFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numbers = new HashSet<int>(Console.ReadLine().Split().Select(int.Parse));

            Func<int, int, bool> number = (number, lower) => number < lower;

            int checkNumber = int.MaxValue;
            foreach (var item in numbers)
            {
                if (number(item, checkNumber))
                {
                    checkNumber = item;
                }
            }

            Console.WriteLine(checkNumber);
        }
    }
}