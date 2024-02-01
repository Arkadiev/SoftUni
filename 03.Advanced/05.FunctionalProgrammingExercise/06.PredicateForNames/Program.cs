namespace _07.PredicateForNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Func<string, int, bool> predicate = (x, i) => x.Length <= i;

            var result = names.Where(name => predicate(name, length));

            foreach (string name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}