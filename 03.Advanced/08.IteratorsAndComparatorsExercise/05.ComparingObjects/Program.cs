namespace _05.ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] properties = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person();
                
                person.Name = properties[0];
                person.Age = int.Parse(properties[1]);
                person.Town = properties[2];

                people.Add(person);
            }

            Person referencePerson = people[int.Parse(Console.ReadLine()) - 1];

            int equalCount = 0;
            int differentCount = 0;

            foreach (Person person in people)
            {
                if (person.CompareTo(referencePerson) == 0)
                {
                    equalCount++;
                }
                else
                {
                    differentCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {differentCount} {people.Count}");
            }
        }
    }
}