namespace _06._ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> action = null;

            foreach (var name in names)
            {
                action = name => Console.WriteLine(name);
                action(name);
            }
        }
    }
}