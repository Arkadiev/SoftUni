using System.Text;

namespace _06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine();
                return;
            }

            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    resultBuilder.Append(input[i]);
                }

            }

            Console.WriteLine(resultBuilder);
        }
    }
}