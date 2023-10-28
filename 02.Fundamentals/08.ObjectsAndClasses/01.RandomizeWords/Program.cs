namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            Random rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);

                string word1 = words[pos1];
                string word2 = words[pos2];

                words[pos1] = word2;
                words[pos2] = word1;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}