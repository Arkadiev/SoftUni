using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double requiredMoney = double.Parse(Console.ReadLine());
            double currentBalance = double.Parse(Console.ReadLine());

            int consecutiveSpendOperations = 0;
            int totalDaysCount = 0;

            while (currentBalance < requiredMoney && consecutiveSpendOperations < 5)
            {
                string operationType = Console.ReadLine();
                double operationAmount = double.Parse(Console.ReadLine());

                if (operationType == "save")
                {
                    consecutiveSpendOperations = 0;
                    currentBalance += operationAmount;
                }
                else if (operationType == "spend")
                {
                    consecutiveSpendOperations++;
                    currentBalance -= operationAmount;
                    if (currentBalance < 0)
                    {
                        currentBalance = 0;
                    }
                }
                totalDaysCount++;
            }

            if (currentBalance >= requiredMoney)
            {
                Console.WriteLine($"You saved the money for {totalDaysCount} days.");
            }
            else
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine(totalDaysCount);
            }
        }
    }
}
