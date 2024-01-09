using System.Text;

namespace _05.DecryptingMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                char input = char.Parse(Console.ReadLine());

                int inputNew = (int)input + key;

                Console.Write((char)inputNew);
            }
        }
    }
}