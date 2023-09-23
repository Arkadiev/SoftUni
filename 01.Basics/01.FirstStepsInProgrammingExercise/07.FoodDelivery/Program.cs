using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenAmount = int.Parse(Console.ReadLine());
            int fishAmount = int.Parse(Console.ReadLine());
            int vegetarianAmount = int.Parse(Console.ReadLine());

            double chickenPrice = chickenAmount * 10.35;
            double fishPrice = fishAmount * 12.4;
            double vegetarianPrice = vegetarianAmount * 8.15;

            double foodPrice = chickenPrice + fishPrice + vegetarianPrice;
            double dessertPrice = foodPrice * 0.2;

            double totalPrice = foodPrice + dessertPrice + 2.5;

            Console.WriteLine(totalPrice);

        }
    }
}
