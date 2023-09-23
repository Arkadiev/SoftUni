using System;

namespace _05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liquid = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double totalPrice = pens * 5.8 + markers * 7.2 + liquid * 1.2;

            double totalPriceWithDiscount = totalPrice - (discount * 0.01) * totalPrice;

            Console.WriteLine(totalPriceWithDiscount);

        }
    }
}
