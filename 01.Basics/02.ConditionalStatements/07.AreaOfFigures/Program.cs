using System;
using System.Drawing;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double area = a * a;
                Console.WriteLine("{0:F3}", area);
            }
            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = a * b;
                Console.WriteLine("{0:F3}", area);
            }
            else if (figure == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double area = Math.PI * Math.Pow(a, 2);
                Console.WriteLine("{0:F3}", area);
            }
            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double area = (a * b) / 2;
                Console.WriteLine("{0:F3}", area);
            }
        }
    }
}
