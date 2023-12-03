/*
programmer: an animal, which turns coffee into code | developer: a magician
fish | domino
Hand Over

care: worry, anxiety, or concern | care: a state of mind in which one is troubled | face: the front part of the head, from the forehead to the chin
care | kitchen | flower
Test

tackle: the equipment required for a task or sport | code: write code for a computer program | bit: a small piece, or quantity of something | tackle: make determined efforts to deal with a problem | bit: a short time or distance
bit | code | tackle
Test
 
 */

using System.Text;

namespace _03.Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine().Split(" | ");

            foreach (string entry in input)
            {
                string[] newEntry = entry.Split(": ");
                string currentWord = newEntry[0];
                string currentDefinition = newEntry[1];

                if (!words.ContainsKey(currentWord))
                {
                    words[currentWord] = new List<string>();
                }

                words[currentWord].Add(currentDefinition);
            }

            string[] teacherInput = Console.ReadLine().Split(" | ").ToArray();
            
            string command = Console.ReadLine();
            if (command == "Test")
            {
                foreach (var word in teacherInput)
                {
                    if (words.ContainsKey(word))
                    {
                        Console.WriteLine($"{word}:");
                        foreach (var definition in words[word])
                        {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            }
            else // Hand Over
            {
                Console.WriteLine(string.Join(" ", words.Keys));
            }
        }
    }
}