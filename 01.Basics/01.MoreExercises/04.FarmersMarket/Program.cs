using System;

namespace _04.FarmersMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vegetablesPrice = double.Parse(Console.ReadLine());
            var fruitsPrice = double.Parse(Console.ReadLine());
            var vegetablesAmount = int.Parse(Console.ReadLine());
            var fruitsAmount = int.Parse(Console.ReadLine());

            var priceLeva = (vegetablesPrice * vegetablesAmount) + (fruitsPrice * fruitsAmount);
            var priceEuro = priceLeva / 1.94;

            Console.WriteLine("{0:f2}", priceEuro);

        }
    }
}
