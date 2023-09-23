using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapesPerSquareMeter = double.Parse(Console.ReadLine());
            double wineNeeded = double.Parse(Console.ReadLine());
            int workers = int.Parse(Console.ReadLine());

            double totalWine = (area * grapesPerSquareMeter) * 0.4 / 2.5;
            double litersPerPerson = (totalWine - wineNeeded) / workers;

            if (totalWine >= wineNeeded)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Ceiling(totalWine)} liters.");
                Console.WriteLine($"{totalWine - wineNeeded} liters left -> {Math.Ceiling(litersPerPerson)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeeded - totalWine)} liters wine needed.");
            }

        }
    }
}
