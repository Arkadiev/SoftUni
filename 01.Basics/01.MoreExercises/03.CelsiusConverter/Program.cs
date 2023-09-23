using System;

namespace _03.CelsiusConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = double.Parse(Console.ReadLine());

            var fahrenheit = ((celsius * 9) / 5) + 32;

            Console.WriteLine("{0:f2}", fahrenheit);
        }
    }
}
