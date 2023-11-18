using System.Text;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = PricessExplosions(input);
            Console.WriteLine(result);
        }

        private static string PricessExplosions(string input)
        {
            StringBuilder resultBuilder = new StringBuilder();

            int strength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    strength += int.Parse(input[i + 1].ToString());
                    resultBuilder.Append(input[i]);
                }
                else if (strength == 0)
                {
                    resultBuilder.Append(input[i]);
                }
                else
                {
                    strength--;
                }
            }

            return resultBuilder.ToString();
        }
    }
}