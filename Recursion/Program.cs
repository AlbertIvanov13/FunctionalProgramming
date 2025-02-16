namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintN(10);
        }

        public static void PrintN(int n)
        {
            if (n == 0)
            {
                return;
            }

            Console.WriteLine(n);
            PrintN(n - 1);
        }
    }
}