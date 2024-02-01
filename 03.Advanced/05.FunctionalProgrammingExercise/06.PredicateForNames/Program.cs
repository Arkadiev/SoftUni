namespace _06.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Predicate<string> predicate = x => x.Length <= length;

            var result = names.Where(name => predicate(name));

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}