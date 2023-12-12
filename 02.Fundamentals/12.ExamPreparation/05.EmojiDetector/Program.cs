using System.Numerics;
using System.Text.RegularExpressions;

namespace _05.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger numbersSum = 1;
            string numbersPattern = @"(?<number>\d)";
            foreach (Match numberMatch in Regex.Matches(input, numbersPattern))
            {
                numbersSum *= int.Parse(numberMatch.Groups["number"].Value);
            }

            List<string> emojis = new List<string>();

            BigInteger emojisCount = 0;
            string emojisPattern = @"(::|\*\*)(?<word>[A-Z][a-z]{2,})(\1)";
            foreach (Match emojiMatch in Regex.Matches(input, emojisPattern))
            {
                emojisCount += 1;
                BigInteger lettersSum = 0;

                string currentWord = emojiMatch.Groups["word"].Value;
                for (int i = 0; i < currentWord.Length; i++)
                {
                    lettersSum += currentWord[i];
                }

                if (lettersSum > numbersSum)
                {
                    emojis.Add(emojiMatch.Value);
                }
            }

            Console.WriteLine($"Cool threshold: {numbersSum}");
            Console.WriteLine($"{emojisCount} emojis found in the text. The cool ones are:");

            foreach (string emoji in emojis)
            {
                Console.WriteLine(emoji);
            }
            
        }
    }
}