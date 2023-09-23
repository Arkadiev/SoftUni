using System;

namespace _04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (season == "Spring")
            {
                totalPrice = 3000;
            }
            else if (season == "Summer")
            {
                totalPrice = 4200;
            }
            else if (season == "Autumn")
            {
                totalPrice = 4200;
            }
            else if (season == "Winter")
            {
                totalPrice = 2600;
            }

            if (fishermen <= 6)
            {
                totalPrice *= 0.9;
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                totalPrice *= 0.85;
            }
            else if (fishermen >= 12)
            {
                totalPrice *= 0.75;
            }

            if (season != "Autumn")
            {
                if (fishermen % 2 == 0)
                {
                    totalPrice *= 0.95;
                }
            }

            if (totalPrice <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - totalPrice:f2} leva left.");
            }
            else if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva.");
            }
        }
    }
}
