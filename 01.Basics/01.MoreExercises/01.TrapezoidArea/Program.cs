using System;

namespace _01.TrapezoidArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var b1 = double.Parse(Console.ReadLine());
            var b2 = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            var result = (b1 + b2) * h / 2;

            Console.WriteLine("{0:f2}", result);
        }
    }
}
