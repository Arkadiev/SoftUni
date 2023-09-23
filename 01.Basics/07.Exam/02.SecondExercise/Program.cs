using System;

namespace _02.SecondExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double allowance = double.Parse(Console.ReadLine());
            double salesMoney = double.Parse(Console.ReadLine());
            double spendings = double.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double allowanceTotal = allowance * 5;
            double salesMoneyTotal = salesMoney * 5;
            double savedMoney = allowanceTotal + salesMoneyTotal;
            double totalSavedMoney = savedMoney - spendings;

            double diff = Math.Abs(totalSavedMoney - giftPrice);

            if (totalSavedMoney >= giftPrice)
            {
                Console.WriteLine($"Profit: {totalSavedMoney:f2} BGN, the gift has been purchased.");
            }
            else
            {
                Console.WriteLine($"Insufficient money: {diff:f2} BGN.");
            }

        }
    }
}
