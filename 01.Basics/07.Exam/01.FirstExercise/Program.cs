using System;

namespace _01.FirstExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cpuPrice = double.Parse(Console.ReadLine());
            double gpuPrice = double.Parse(Console.ReadLine());
            double ramPrice = double.Parse(Console.ReadLine());

            int ramCount = int.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double price = cpuPrice + gpuPrice;

            double priceLeva = price * 1.57;
            double ramPriceLeva = (ramPrice * ramCount) * 1.57;
            double finalPrice = priceLeva - (priceLeva * discount) + ramPriceLeva;

            Console.WriteLine($"Money needed - {finalPrice:f2} leva.");

        }
    }
}
