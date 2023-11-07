namespace _01.CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            SortedDictionary<int, int> numberOccurrences = new SortedDictionary<int, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (!numberOccurrences.ContainsKey(numbers[i]))
                {
                    numberOccurrences[numbers[i]] = 1;
                }
                else
                {
                    numberOccurrences[numbers[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> item in numberOccurrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}