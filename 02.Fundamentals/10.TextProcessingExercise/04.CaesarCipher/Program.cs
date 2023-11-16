using System.Text;

namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                char original = input[i];
                sb.Append((char)(original + 3));
            }

            Console.WriteLine(sb);
        }
    }
}