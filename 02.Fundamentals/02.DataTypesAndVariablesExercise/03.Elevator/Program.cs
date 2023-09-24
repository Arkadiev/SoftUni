namespace _03.Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int courses = people / capacity;
            int leftovers = people % capacity;

            if (leftovers > 0)
            {
                Console.WriteLine(courses+1);
            }
            else
            {
                Console.WriteLine(courses);
            }

        }
    }
}