namespace PracticingFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            Func<double, float, int> combineFunc = Add;

            Console.WriteLine(combineFunc(x, y));
        }
        public static int Add(double x, float y)
        {
            return (int)(x + y);
        }
    }
}