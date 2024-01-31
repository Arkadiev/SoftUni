namespace _04.AddVAT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal[] numbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(decimal.Parse).Select(x => x * 1.2m).ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}