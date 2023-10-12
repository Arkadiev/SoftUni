namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            int vowelsCount = Vowels(input);

            Console.WriteLine(vowelsCount);

            static int Vowels(string input)
            {
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (isVowel(input[i])) { count++; }
                }
                return count;
            }
            static bool isVowel(char input)
            {
                return (input == 'a' || input == 'A' || input == 'e' || input == 'E' || input == 'o' || input == 'O'
                     || input == 'i' || input == 'I' || input == 'y' || input == 'Y' || input == 'u' || input == 'U');
            }
        }
    }
}