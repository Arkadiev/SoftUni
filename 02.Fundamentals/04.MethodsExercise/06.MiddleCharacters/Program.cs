using System.ComponentModel.Design;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine(MiddleCharacter(input));

            static string MiddleCharacter(string input)
            {
                int length = input.Length;
                string result = "";

                if (length % 2 != 0)
                {
                    result = input[input.Length / 2].ToString();
                }
                else
                {
                    result = input[input.Length / 2 - 1].ToString() + input[input.Length / 2].ToString();
                }
                return result;
            }

        }
    }
}