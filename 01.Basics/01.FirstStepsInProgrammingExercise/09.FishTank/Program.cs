using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double size = lenght * width * height;
            double sizeLiters = size * 0.001;
            double percentReal = percent * 0.01;

            double total = sizeLiters * (1 - percentReal);

            Console.WriteLine(total);

        }
    }
}
