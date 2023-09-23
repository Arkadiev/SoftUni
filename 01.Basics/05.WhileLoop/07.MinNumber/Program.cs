using System;

namespace _07.MinNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int minNumber = int.MaxValue;

            while (input != "Stop")
            {
                int num = int.Parse(input);

                if (num < minNumber) { minNumber = num; }

                input = Console.ReadLine();
            }

            Console.WriteLine(minNumber);
        }
    }
}
