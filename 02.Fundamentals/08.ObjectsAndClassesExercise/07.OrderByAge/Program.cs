using System;

namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                string name = arguments[0];
                int id = int.Parse(arguments[1]);
                int age = int.Parse(arguments[2]);

                Person person = new Person(name, id, age);

                bool idAlreadyExists = people.Any(p => p.Id == id);

                if (idAlreadyExists)
                {
                    Person duplicate = people.First(person => person.Id == id);
                    people.Remove(duplicate);
                    people.Add(person);
                }
                else
                {
                    people.Add(person);
                }
            }

            people = people.OrderBy(p => p.Age).ToList();

            for (int i = 0; i < people.Count - 1; i++)
            {
                Console.Write($"{people[i].Name} with ID: {people[i].Id} is {people[i].Age} years old.\n");
            }

            Console.Write($"{people[people.Count - 1].Name} with ID: {people[people.Count - 1].Id} is {people[people.Count - 1].Age} years old.\n");

        }
    }

    public class Person
    {
        public Person(string name, int id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public int Id { get; set; }

        public int Age { get; set; }
    }
}