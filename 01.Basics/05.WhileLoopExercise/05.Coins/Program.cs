using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal amount = decimal.Parse(Console.ReadLine());
            int coinsCounter = 0;

            while (amount > 0)
            {
                if (amount >= 2) { amount -= 2; }
                else if (amount >= 1) { amount -= 1; }
                else if (amount >= 0.5m) { amount -= 0.5m; }
                else if (amount >= 0.2m) { amount -= 0.2m; }
                else if (amount >= 0.1m) { amount -= 0.1m; }
                else if (amount >= 0.05m) { amount -= 0.05m; }
                else if (amount >= 0.02m) { amount -= 0.02m; }
                else { amount -= 0.01m; }

                coinsCounter++;
            }

            Console.WriteLine(coinsCounter);
        }
    }
}
