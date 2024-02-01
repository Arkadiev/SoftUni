namespace _08.ListOfPredicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int upperLimit = int.Parse(Console.ReadLine());

            int[] divisors = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            List<int> numbers = new();

            for (int i = 1; i <= upperLimit; i++)
            {
                numbers.Add(i);
            }

            Func<int[], int, bool> predicate = (arr, i) =>
            {
                bool isDivisible = true;

                foreach (int n in divisors)
                {
                    if (i % n != 0)
                    {
                        return false;
                    }
                }
                return isDivisible;
            };

            var result = numbers.Where(n => predicate(divisors, n));

            Console.WriteLine(string.Join(" ", result));
        }
    }
}