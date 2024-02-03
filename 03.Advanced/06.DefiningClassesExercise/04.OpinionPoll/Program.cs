namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                people.Add(new Person(input[0], int.Parse(input[1])));
            }

            var result = people.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach (Person person in result)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}