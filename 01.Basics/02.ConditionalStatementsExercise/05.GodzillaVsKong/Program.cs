using System;

namespace _05.GodzillaVsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int cast = int.Parse(Console.ReadLine());
            double castOutfits = double.Parse(Console.ReadLine());

            double decoration = budget * 0.1;

            double outfitsPrice = cast * castOutfits;

            if (cast > 150) {outfitsPrice *= 0.9;}

            double totalPrice = decoration + outfitsPrice;

            if (totalPrice <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget - totalPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalPrice - budget:f2} leva more.");
            }
        }
    }
}
