namespace _10._AppliedArithmetics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Func<int[], int[]> addingFunc = numbers =>
            {
                List<int> newList = new List<int>(numbers.Length);
                for (int i = 0; i < numbers.Length; i++)
                {
                    newList.Add(numbers[i]++);
                }
                numbers = newList.ToArray();
                return numbers;
            };

            Func<int[], int[]> multiplyFunc = numbers =>
            {
                List<int> newList = new List<int>(numbers.Length);
                for (int i = 0; i < numbers.Length; i++)
                {
                    newList.Add(numbers[i]*=2);
                }
                numbers = newList.ToArray();
                return numbers;
            };

            Func<int[], int[]> subtractFunc = numbers =>
            {
                List<int> newList = new List<int>(numbers.Length);
                for (int i = 0; i < numbers.Length; i++)
                {
                    newList.Add(numbers[i]--);
                }
                numbers = newList.ToArray();
                return numbers;
            };

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "add":
                        addingFunc(numbers); break;
                    case "multiply":
                        multiplyFunc(numbers); break;
                    case "subtract":
                        subtractFunc(numbers); break;
                    case "print":
                        Console.WriteLine(string.Join(" ", numbers));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}