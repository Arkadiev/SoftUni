using System.Diagnostics.CodeAnalysis;

namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int num = i;
                int sum = 0;

                while (num > 0)
                {
                    int lastDigit = num % 10;
                    sum += lastDigit;
                    num /= 10;
                }

                bool isSpecial = sum == 5 || sum == 7 || sum == 11;

                if (isSpecial)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }

            }
     
        }
    }
}