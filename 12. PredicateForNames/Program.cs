namespace _12._PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int namesLength = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split().ToArray();

            List<string> checkedNames = new List<string>();

            Predicate<string> checker = n => n.Length <= namesLength;

            Func<string[], string[]> nameCheck = checkNames =>
            {
                foreach (var name in names)
                {
                    if (checker(name))
                    {
                        checkedNames.Add(name);
                    }
                }

                return checkedNames.ToArray();
            };

            Console.WriteLine($"{string.Join(Environment.NewLine, nameCheck(names))}");
        }
    }
}