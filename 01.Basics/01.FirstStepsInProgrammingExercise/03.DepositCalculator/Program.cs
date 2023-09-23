using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int depositTerm = int.Parse(Console.ReadLine());
            double depositInterest = double.Parse(Console.ReadLine());

            double depositTotal = depositSum + depositTerm * (depositSum * depositInterest * 0.01 / 12);

            Console.WriteLine(depositTotal);
        }
    }
}
