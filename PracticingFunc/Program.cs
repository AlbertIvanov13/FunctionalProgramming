namespace PracticingFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            var result = Where(array,isEven);

            Console.WriteLine(string.Join(", ", result));

        }
        public static int[] Where(int[] array, Func<int, bool> checker)
        {
            List<int> result = new List<int>();

            foreach (var item in array)
            {
                if (checker(item))
                {
                    result.Add(item);
                }
            }

            return result.ToArray();
        }

        public static bool isEven(int number)
        {
            return number % 2 == 0;
        }
    }
}