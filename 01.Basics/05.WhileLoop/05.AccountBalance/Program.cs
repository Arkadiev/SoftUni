using System;

namespace _05.AccountBalance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double total = 0;

            while (input != "NoMoreMoney")
            {
                double amount = double.Parse(input);

                if (amount < 0) { Console.WriteLine("Invalid operation!"); break; }

                Console.WriteLine($"Increase: {amount:f2}");
                total += amount;

                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
