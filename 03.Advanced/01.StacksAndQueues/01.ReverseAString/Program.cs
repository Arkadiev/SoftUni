namespace _01.ReverseAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> word = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                word.Push(input[i]);
            }

            while (word.Count > 0)
            {
                Console.Write(word.Pop());
            }
        }
    }
}