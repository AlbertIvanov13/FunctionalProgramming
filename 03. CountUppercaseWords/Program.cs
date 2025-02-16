namespace _03._CountUppercaseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var result = UppercaseWord(words);

            foreach ( var word in result )
            {
                Console.WriteLine(word);
            }
        }

        public static string[] UppercaseWord(string[] words)
        {
            List<string> uppercaseWords = new List<string>();


            foreach (string word in words)
            {
                Func<string, bool> func = (word) => char.IsUpper(word[0]);
                if (func(word))
                {
                    uppercaseWords.Add(word);
                }
            }

            return uppercaseWords.ToArray();
        }
    }
}