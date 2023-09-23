using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int total = a + b + c;

            int totalMin = total / 60;
            int totalSec = total % 60;

            if (totalSec < 10)
            {
                Console.WriteLine($"{totalMin}:0{totalSec}");
            }
            else
            {
                Console.WriteLine($"{totalMin}:{totalSec}");
            }

        }
    }
}
