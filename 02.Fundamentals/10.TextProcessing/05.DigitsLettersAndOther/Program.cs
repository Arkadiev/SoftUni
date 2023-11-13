using System.Text;

namespace _05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char character = input[i];

                if (char.IsDigit(character))
                {
                    digits.Append(character);
                }
                else if (char.IsLetter(character))
                {
                    letters.Append(character);
                }
                else
                {
                    characters.Append(character);
                }
            }

            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}