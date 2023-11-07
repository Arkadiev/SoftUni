namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();

            var numberOccurrences = new Dictionary<string, int>();

            for (int i = 0; i < words.Length; i++)
            {
                if (!numberOccurrences.ContainsKey(words[i]))
                {
                    numberOccurrences.Add(words[i], 1);
                }
                else
                {
                    numberOccurrences[words[i]]++;
                }
            }

            foreach (KeyValuePair<string, int> kvp in numberOccurrences)
            {
                if (kvp.Value % 2 == 1)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }

        }
    }
}