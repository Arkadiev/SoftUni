using System;
using System.Security.Cryptography;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripPrice = double.Parse(Console.ReadLine());

            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalAmount = puzzles + dolls + bears + minions + trucks;
            double totalPrice = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;

            if (totalAmount >= 50)
            {
                totalPrice = totalPrice - (totalPrice * 0.25); // totalPrice = totalPrice * 0.75;
            }

            double totalPriceAfterRent = totalPrice - (totalPrice * 0.1); // totalPrice = totalPrice * 0.9;

            if (totalPriceAfterRent >= tripPrice)
            {
                double totalTotal = totalPriceAfterRent - tripPrice;
                Console.WriteLine($"Yes! {totalTotal:f2} lv left.");
            }
            else
            {
                double moneyNeeded = tripPrice - totalPriceAfterRent;
                Console.WriteLine($"Not enough money! {moneyNeeded:f2} lv needed.");
            }
        }
    }
}
