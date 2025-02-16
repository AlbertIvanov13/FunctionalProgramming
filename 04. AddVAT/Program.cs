namespace _04._AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] prices = Console.ReadLine().Split(", ").Select(double.Parse).ToArray();

            var results = Prices(prices);

            foreach (var item in results)
            {
                Console.WriteLine($"{item:f2}");
            }
        }

        public static double[] Prices(double[] prices)
        {
            List<double> numbers = new List<double>();
            foreach (var item in prices)
            {
                Func<double, double> func = x => item * 1.20;
                numbers.Add(func(item));
            }

            return numbers.ToArray();
        }
    }
}