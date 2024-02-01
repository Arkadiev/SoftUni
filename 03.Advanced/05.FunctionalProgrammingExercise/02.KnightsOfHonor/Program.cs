namespace _02.KnightsOfHonor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            Action<string> promote = s => Console.WriteLine($"Sir {s}");

            Array.ForEach(input, promote);
        }
    }
}