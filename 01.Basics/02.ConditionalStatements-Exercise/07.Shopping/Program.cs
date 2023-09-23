using System;

namespace _07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());

            double gpuPrice = 250;
            double cpuPrice = gpu * gpuPrice * 0.35;
            double ramPrice = gpu * gpuPrice * 0.1;

            double totalPrice = gpu * gpuPrice + cpu * cpuPrice + ram * ramPrice;

            if (gpu > cpu) totalPrice *= 0.85;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:f2} leva more!");
            }
        }
    }
}
