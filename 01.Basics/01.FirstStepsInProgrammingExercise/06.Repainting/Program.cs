using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            double nylonPrice = (nylon + 2) * 1.50;
            double paintPrice = (paint + 0.1 * paint) * 14.5; // or 1.1 * paint * 14.5
            double diluentPrice = diluent * 5;
            double materialsPrice = nylonPrice + paintPrice + diluentPrice + 0.4;

            double wagePerHour = materialsPrice * 0.3;

            double totalPrice = materialsPrice + wagePerHour * hours;

            Console.WriteLine(totalPrice);

        }
    }
}
