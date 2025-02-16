namespace _05._FilterByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] personData = Console.ReadLine().Split(", ").ToArray();
                string personName = personData[0];
                int personAge = int.Parse(personData[1]);

                Person person = new Person();
                person.Name = personName;
                person.Age = personAge;
                persons.Add(person);
            }

            string type = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            var filter  = GetFilter(type, age);
            persons = persons.Where(filter).ToList();

            var formatter = GetFormatter(format);

            foreach (var person in persons)
            {
                Console.WriteLine(formatter(person));
            }
        }

        public static Func<Person, bool> GetFilter(string type, int age)
        {
            if (type == "older")
            {
                return p => p.Age >= age;
            }
            else
            {
                return p => p.Age < age;
            }
        }

        public static Func<Person, string> GetFormatter(string type)
        {
            if (type == "name")
            {
                return p => p.Name;
            }
            else if (type == "age")
            {
                return p => p.Age.ToString();
            }
            else if (type == "name age")
            {
                return p => $"{p.Name} - {p.Age}";
            }
            return null;
        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
    }
}