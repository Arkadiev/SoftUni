namespace _06.Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> people = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Paid")
                {
                    while (people.Count > 0)
                    {
                        Console.WriteLine(people.Dequeue());
                    }
                }
                else if (input == "End")
                {
                    Console.WriteLine($"{people.Count()} people remaining.");
                    break;
                }
                else
                {
                    people.Enqueue(input);
                }
            }
        }
    }
}