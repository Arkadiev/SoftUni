using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFoodAmount = int.Parse(Console.ReadLine());
            int catFoodAmount = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.50;
            double catFoodPrice = 4;

            double dogFoodTotal = dogFoodAmount * dogFoodPrice;
            double catFoodTotal = catFoodAmount * catFoodPrice;

            double foodTotalPrice = dogFoodTotal + catFoodTotal;

            Console.WriteLine($"{foodTotalPrice} lv.");
        }
    }
}
