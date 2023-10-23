namespace _01.BurgerBus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cityCount = int.Parse(Console.ReadLine());

            double totalProfit = 0;

            for (int i = 1; i <= cityCount; i++)
            {
                string cityName = Console.ReadLine();
                double income = double.Parse(Console.ReadLine());
                double expenses = double.Parse(Console.ReadLine());

                if (i % 5 == 0)
                {
                    income *= 0.9;
                }
                else if (i % 3 == 0)
                {
                    expenses *= 1.5;
                }

                double profit = income - expenses;
                totalProfit += profit;

                Console.WriteLine($"In {cityName} Burger Bus earned {profit:f2} leva.");

            }

            Console.WriteLine($"Burger Bus total profit: {totalProfit:f2} leva.");
        }
    }
}