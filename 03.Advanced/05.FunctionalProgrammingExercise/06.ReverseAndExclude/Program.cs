namespace _06.ReverseAndExclude
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int divisor = int.Parse(Console.ReadLine());

            Predicate<int> predicate = x => x % divisor != 0;

            var result = input.Where(x => predicate(x)).ToArray();

            Console.WriteLine(string.Join(" ", result.Reverse()));
        }
    }
}