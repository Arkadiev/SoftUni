namespace _04.FindEvensOrOdds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            string criteria = Console.ReadLine();

            List<int> numbers = new();

            for (int i = input[0]; i <= input[1]; i++)
            {
                numbers.Add(i);
            }

            Predicate<int> predicate = n => true;

            if (criteria == "even")
            {
                predicate = n => n % 2 == 0;
            }
            else if (criteria == "odd")
            {
                predicate = n => n % 2 != 0;
            }

            var filteredNumbers = numbers.Where(new Func<int, bool>(predicate)).ToArray();

            Console.WriteLine(string.Join(" ", filteredNumbers));
        }
    }
}