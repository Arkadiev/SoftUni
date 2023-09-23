using System;

namespace _08.CircleAreaAndPerimeter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius = double.Parse(Console.ReadLine());

            double area = Math.PI * (radius * radius);
            double perimeter = 2 * Math.PI * radius;

            Console.WriteLine(Math.Round(area, 2));
            Console.WriteLine(Math.Round(perimeter, 2));
        }
    }
}
