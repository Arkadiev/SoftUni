namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());

            Console.WriteLine(CharInRange(start, end));

            static string CharInRange(char start, char end)
            {
                string output = string.Empty;
                int startChar = Math.Min(start, end);
                int endChar = Math.Max(start, end);

                for (int i = startChar + 1; i < endChar; i++)
                {
                    output += (char)i + " ";
                }
                return output;
            }
        }
    }
}