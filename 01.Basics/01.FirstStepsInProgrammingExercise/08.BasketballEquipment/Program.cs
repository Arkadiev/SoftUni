using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int yearlyPrice = int.Parse(Console.ReadLine());

            double shoesPrice = yearlyPrice - 0.4 * yearlyPrice; // 0.6 * yearlyPrice
            double tracksuitPrice = shoesPrice - 0.2 * shoesPrice; // 0.8 * shoesPrice
            double ballPrice = 0.25 * tracksuitPrice; // tracksuitPrice / 4
            double accessoriesPrice = 0.2 * ballPrice; // ballPrice / 2

            double totalPrice = yearlyPrice + shoesPrice + tracksuitPrice + ballPrice + accessoriesPrice;

            Console.WriteLine(totalPrice);
        }
    }
}
