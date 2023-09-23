using System;

namespace _09.YardGreening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Input
            double yardArea = double.Parse(Console.ReadLine());

            // Calculations
            double priceForMeter = 7.61;
            double priceForAllYards = yardArea * priceForMeter;
            double discount = priceForAllYards * 0.18;
            double finalPrice = priceForAllYards - discount;

            //Output
            Console.WriteLine($"The final price is {finalPrice} lv.");
            Console.WriteLine($"The discount is {discount} lv.");
        }
    }
}
