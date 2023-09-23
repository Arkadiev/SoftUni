using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                int number = i, evenSum = 0, oddSum = 0, position = 6;

                while (number != 0)
                {
                    int lastDigit = number % 10;

                    if (position % 2 == 0) { evenSum += lastDigit; }
                    else { oddSum += lastDigit; }

                    number /= 10;
                    position--;
                }

                if (evenSum == oddSum)
                {
                    Console.Write($"{i} ");
                }
            }

        }
    }
}
